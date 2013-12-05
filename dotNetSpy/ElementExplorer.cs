using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation;

namespace dotNetSpy
{
    class ElementExplorer
    {
        private AutomationElement _element;


        public bool HasChildren
        {
            get
            {
                return (_element != null)
                    && (_element.FindAll(TreeScope.Children, Condition.TrueCondition).Count > 0);
            }
        }


        public void SetElement(AutomationElement element)
        {
            _element = element;
        }


        public List<Tuple<string, AutomationElement>> GetChildren()
        {
            var result = new List<Tuple<string, AutomationElement>>();
            try
            {
                AutomationElementCollection children = _element.FindAll(TreeScope.Children, Condition.TrueCondition);
                foreach (AutomationElement child in children)
                    result.Add(Tuple.Create("\"" + child.Current.Name + "\" : " + child.Current.ClassName, child));
            }
            catch { }
            return result;
        }


        public Dictionary<string, string> GetProperties()
        {
            var result = new Dictionary<string, string>();
            try
            {
                result.Add("ChildCount", GetChildren().Count.ToString());
                result.Add("ProcessId", _element.Current.ProcessId.ToString());

                // Simple properties
                result.Add("PROPERTIES", "------------------------------------------");
                result.Add("Name", _element.Current.Name);
                result.Add("AutomationId", _element.Current.AutomationId);
                result.Add("ClassName", _element.Current.ClassName);
                result.Add("LocalizedControlType", _element.Current.LocalizedControlType);
                result.Add("IsEnabled", _element.Current.IsEnabled.ToString());
                result.Add("IsOffscreen", _element.Current.IsOffscreen.ToString());

                Rect rect = _element.Current.BoundingRectangle;
                result.Add("BoundingRectangle", String.Format("{0} x {1} [({2},{3}) - ({4},{5})]",
                    rect.Width, rect.Height, rect.TopLeft.X, rect.TopLeft.Y, rect.BottomRight.X, rect.BottomRight.Y));

                object p;
                bool isValuePatternSupported = _element.TryGetCurrentPattern(ValuePattern.Pattern, out p);
                if (isValuePatternSupported)
                {
                    ValuePattern valuePattern = p as ValuePattern;
                    result.Add("Value", valuePattern.Current.Value);
                }

                // Supported patterns
                result.Add("PATTERNS", "------------------------------------------");
                result.Add("IsDockPatternSupported", _element.TryGetCurrentPattern(DockPattern.Pattern, out p).ToString());
                result.Add("IsExpandCollapsePatternSupported", _element.TryGetCurrentPattern(ExpandCollapsePattern.Pattern, out p).ToString());
                result.Add("IsGridItemPatternSupported", _element.TryGetCurrentPattern(GridItemPattern.Pattern, out p).ToString());
                result.Add("IsGridPatternSupported", _element.TryGetCurrentPattern(GridPattern.Pattern, out p).ToString());
                result.Add("IsInvokePatternSupported", _element.TryGetCurrentPattern(InvokePattern.Pattern, out p).ToString());
                result.Add("IsItemContainerPatternSupported", _element.TryGetCurrentPattern(ItemContainerPattern.Pattern, out p).ToString());
                result.Add("IsMultipleViewPatternSupported", _element.TryGetCurrentPattern(MultipleViewPattern.Pattern, out p).ToString());
                result.Add("IsRangeValuePatternSupported", _element.TryGetCurrentPattern(RangeValuePattern.Pattern, out p).ToString());
                result.Add("IsScrollItemPatternSupported", _element.TryGetCurrentPattern(ScrollItemPattern.Pattern, out p).ToString());
                result.Add("IsScrollPatternSupported", _element.TryGetCurrentPattern(ScrollPattern.Pattern, out p).ToString());
                result.Add("IsSelectionItemPatternSupported", _element.TryGetCurrentPattern(SelectionItemPattern.Pattern, out p).ToString());
                result.Add("IsSelectionPatternSupported", _element.TryGetCurrentPattern(SelectionPattern.Pattern, out p).ToString());
                result.Add("IsSynchronizedInputPatternSupported", _element.TryGetCurrentPattern(SynchronizedInputPattern.Pattern, out p).ToString());
                result.Add("IsTextPatternSupported", _element.TryGetCurrentPattern(TextPattern.Pattern, out p).ToString());
                result.Add("IsTogglePatternSupported", _element.TryGetCurrentPattern(TogglePattern.Pattern, out p).ToString());
                result.Add("IsTransformPatternSupported", _element.TryGetCurrentPattern(TransformPattern.Pattern, out p).ToString());
                result.Add("IsValuePatternSupported", isValuePatternSupported.ToString());
                result.Add("IsVirtualizedItemPatternSupported", _element.TryGetCurrentPattern(VirtualizedItemPattern.Pattern, out p).ToString());
                result.Add("IsWindowPatternSupported", _element.TryGetCurrentPattern(WindowPattern.Pattern, out p).ToString());
            }
            catch { }
            return result;
        }

    }
}

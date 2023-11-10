
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace UnitTestProject1.Elements
{
    public class AppLabel : AppBaseItem
    {
        public AppLabel(SearchCriteria searchCriteria, string friendlyname) : base(searchCriteria, friendlyname)
        {
        }

        public string GetLabelText()
        {
            var uiItem = UIGetElement();
            if (uiItem is Label labelElement)
            {
                return labelElement.Text;
            }
            return null;
        }

    }
}

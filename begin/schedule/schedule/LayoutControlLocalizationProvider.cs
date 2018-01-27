using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace schedule {
    class MyEnglishLayoutControlLocalizationProvider : LayoutControlLocalizationProvider {
        public override string GetLocalizedString(string id) {
            switch (id) {
                case LayoutControlStringId.CustomizeDialogHiddenItems:
                    return "Скрытых элементов ({0})";
                case LayoutControlStringId.CustomizeDialogNewItems:
                    return "Новых элементов ({0})";

                case LayoutControlStringId.CustomizeDialogPageItems:
                    return "Элементы";
                case LayoutControlStringId.CustomizeDialogPageStructure:
                    return "Структура";

                case LayoutControlStringId.CustomizeDialogRootItem:
                    return "Root";
                case LayoutControlStringId.CustomizeDialogLayoutItem:
                    return "Layout Item";
                case LayoutControlStringId.CustomizeDialogLabelItem:
                    return "Label Item";
                case LayoutControlStringId.CustomizeDialogSplitterItem:
                    return "Splitter Item";
                case LayoutControlStringId.CustomizeDialogSeparatorItem:
                    return "Separator Item";
                case LayoutControlStringId.CustomizeDialogGroupItem:
                    return "Group Item";
                case LayoutControlStringId.CustomizeDialogTabbedGroup:
                    return "Tabbed Group";

                case LayoutControlStringId.CustomizeDialogSaveLayout:
                    return "Save Layout";
                case LayoutControlStringId.CustomizeDialogLoadLayout:
                    return "Load Layout";

                case LayoutControlStringId.NewGroupDefaultText:
                    return "Item Group";
                case LayoutControlStringId.NewLabelDefaultText:
                    return "Label Item";

                case LayoutControlStringId.CustomizeDialogNewItemsEmptySpace:
                    return "Empty Space";
                case LayoutControlStringId.CustomizeDialogNewItemsLabel:
                    return "Label";
                case LayoutControlStringId.CustomizeDialogNewItemsSeparator:
                    return "Separator";
                case LayoutControlStringId.CustomizeDialogNewItemsSplitter:
                    return "Splitter";
                case LayoutControlStringId.CustomizeDialogNewItemsGroup:
                    return "Group";
                case LayoutControlStringId.CustomizeDialogNewItemsTabbedGroup:
                    return "Tabbed Group";

                case LayoutControlStringId.ContextMenuCustomize:
                    return "Править";
                case LayoutControlStringId.ContextMenuHideItem:
                    return "Скрыть";
                case LayoutControlStringId.CustomizeDialogTitle:
                    return "Править";

                case LayoutControlStringId.ErrorBoxTitle:
                    return "Ошибка!";
                case LayoutControlStringId.ErrorFileNotFoundMessage:
                    return "File not found!";
                case LayoutControlStringId.ErrorLoadingLayoutMessage:
                    return "Error loading layout!";
            }

            return base.GetLocalizedString(id);
        }
    }
}

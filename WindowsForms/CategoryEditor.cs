using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using System.Drawing.Design;
using System.Windows.Forms;

namespace WindowsForms
{
    public class CategoryEditor : UITypeEditor
    { 
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));

            if(edSvc != null)
            {
                ChangeCategory changeCategory = new ChangeCategory((Category)value);
                edSvc.DropDownControl(changeCategory);
                return changeCategory.Category;
            }

            return value;
        }
    }
}

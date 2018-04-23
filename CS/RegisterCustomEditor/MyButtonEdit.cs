using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;

namespace RegisterCustomEditor
{
    [UserRepositoryItem("Register")]
    public class RepositoryItemMyButtonEdit : RepositoryItemButtonEdit
    {
        static RepositoryItemMyButtonEdit()
        {
            Register();
        }
        public RepositoryItemMyButtonEdit() { }

        internal const string EditorName = "MyButtonEdit";

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MyButtonEdit),
                typeof(RepositoryItemMyButtonEdit), typeof(DevExpress.XtraEditors.ViewInfo.ButtonEditViewInfo),
                new DevExpress.XtraEditors.Drawing.ButtonEditPainter(), true, null));
        }
        public override string EditorTypeName
        {
            get { return EditorName; }
        }
    }

    /// <summary>
    /// MyButtonEdit is a descendant from ButtonEdit.
    /// It displays a dialog form below the text box when the edit button is clicked.
    /// </summary>
    public class MyButtonEdit : ButtonEdit
    {
        static MyButtonEdit()
        {
            RepositoryItemMyButtonEdit.Register();
        }
        public MyButtonEdit() { }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            Console.WriteLine("d");
        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            Console.WriteLine("e");
        }
        public override string EditorTypeName
        {
            get { return RepositoryItemMyButtonEdit.EditorName; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyButtonEdit Properties
        {
            get { return base.Properties as RepositoryItemMyButtonEdit; }
        }

        protected override void OnClickButton(DevExpress.XtraEditors.Drawing.EditorButtonObjectInfoArgs buttonInfo)
        {
            ShowPopupForm();
            base.OnClickButton(buttonInfo);
        }
        protected virtual void ShowPopupForm()
        {
            using (Form form = new Form())
            {
                form.StartPosition = FormStartPosition.Manual;
                form.Location = this.PointToScreen(new Point(0, Height));
                form.ShowDialog();
            }
        }
    }
}

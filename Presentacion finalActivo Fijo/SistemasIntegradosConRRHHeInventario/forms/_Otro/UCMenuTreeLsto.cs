using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.Seguridad;
using Core.Erp.Info.Seguridad;

namespace forms._Otro
{
    public partial class UCMenuTreeLsto : UserControl
    {
        datMenuPadre oDatMenu = new datMenuPadre();
        datModulo oDatModulo = new datModulo();
        datPerfil oDatPerfil = new datPerfil();
        public UCMenuTreeLsto()
        {
            InitializeComponent();           
            cbxModulo.Properties.DataSource = oDatModulo.ConsultaModulos();
            cbxPerfil.Properties.DataSource = oDatPerfil.ConsultarPerfiles();
        }
        private void UCMenuTreeLsto_Load(object sender, EventArgs e)
        {          
        }
        private void cmbModulo_EditValueChanged(object sender, EventArgs e)
        {
            trlPerfil.DataSource = oDatMenu.ConsultarMenu().FindAll(v => v.IdModulo == Convert.ToInt32(cbxModulo.EditValue));
            trlPerfil.ExpandAll();
            cmbPerfil_EditValueChanged(new Object(), new EventArgs());
        }
        public void chequearHijos(DevExpress.XtraTreeList.Nodes.TreeListNode Nodo, Boolean Valor)
        {
            if(Nodo.HasChildren)
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode item in Nodo.Nodes)
                {
                    if (Nodo.HasChildren)
                        chequearHijos(item, Valor);
                    item.Checked = Valor;
                }
        }
        private void treeList1_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {            
            if (!e.Node.Checked)
            {
                if (e.Node.HasChildren)
                {
                    foreach (DevExpress.XtraTreeList.Nodes.TreeListNode item in e.Node.Nodes)
                    {
                        if (item.HasChildren)
                            chequearHijos(item, false);
                        item.Checked = false;                      
                        try
                        {
                            e.Node.ParentNode.Checked = false;
                        }
                        catch (Exception)
                        {
                            
                        }
                    }
                }
            }
            else
            {
                if (e.Node.HasChildren)
                {
                    foreach (DevExpress.XtraTreeList.Nodes.TreeListNode item in e.Node.Nodes)
                    {
                        if (item.HasChildren)
                            chequearHijos(item,true);
                        item.Checked = true;
                    }
                }
                try
                {
                    e.Node.ParentNode.Checked = true;
                    e.Node.ParentNode.ParentNode.Checked = true;
                    e.Node.ParentNode.ParentNode.ParentNode.Checked = true;
                    e.Node.ParentNode.ParentNode.ParentNode.ParentNode.Checked = true;
                    e.Node.ParentNode.ParentNode.ParentNode.ParentNode.ParentNode.Checked = true;
                    e.Node.ParentNode.ParentNode.ParentNode.ParentNode.ParentNode.ParentNode.Checked = true;
                }
                catch (Exception)
                {
                    
                }       
            }
        }
        List<clsMenu> ListSave = new List<clsMenu>();
        void ObtenerParaGuardar(DevExpress.XtraTreeList.Nodes.TreeListNode Nodo) 
        {
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode item in Nodo.Nodes)
            {
                if (item.Checked)
                {
                  //  var Obj = (clsMenu)treeList1.GetDataRecordByNode(item);
                    ListSave.Add((clsMenu)trlPerfil.GetDataRecordByNode(item));
                    ObtenerParaGuardar(item);
                }
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ListSave.Clear();
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode  item in trlPerfil.Nodes)
            {
                if (item.Checked)
                {
                    ListSave.Add((clsMenu)trlPerfil.GetDataRecordByNode(item));
                    ObtenerParaGuardar(item);
                }
            }
            List<Permiso> oListaPermiso = new List<Permiso>();
            foreach (var item in ListSave)
            {
                Permiso obj = new Permiso();
                obj.Eliminacion = false;
                obj.Lectura = false;
                obj.Escritura = false;
                obj.IdMenu = item.IdMenu;
                obj.IdModulo = Convert.ToInt32(cbxModulo.EditValue);
                obj.IdPerfil = Convert.ToInt32(cbxPerfil.EditValue);
                oListaPermiso.Add(obj);                
            }
            if (oDatPermiso.Guardar(oListaPermiso, Convert.ToInt32(cbxPerfil.EditValue), Convert.ToInt32(cbxModulo.EditValue)))
            {
                MessageBox.Show("Guardado Ok");
                if (MessageBox.Show("Desea Reiniciar? ", "TECA™", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Restart();
                }
                
            }
        }
        datPermiso oDatPermiso = new datPermiso();
        public void ChequearEnConsulta(List<Permiso> Consulta, DevExpress.XtraTreeList.Nodes.TreeListNode Nodos) 
        {
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Nodo in Nodos.Nodes)
            {
                foreach (var item in Consulta)
                {
                    var obj = (((clsMenu)trlPerfil.GetDataRecordByNode(Nodo)));
                    if (obj.IdMenu == item.IdMenu)
                        Nodo.Checked = true;
                    if (Nodo.HasChildren)
                        ChequearEnConsulta(Consulta, Nodo);
                }
            }
        }
        private void cmbPerfil_EditValueChanged(object sender, EventArgs e)
        {
            trlPerfil.UncheckAll();
            List<Permiso> Consulta = oDatPermiso.Consultar(Convert.ToInt32(cbxPerfil.EditValue), Convert.ToInt32(cbxModulo.EditValue));
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode Nodo in trlPerfil.Nodes)
            {
                foreach (var item in Consulta)
                {
                    var obj = (((clsMenu)trlPerfil.GetDataRecordByNode(Nodo)));
                    if (obj.IdMenu == item.IdMenu)
                        Nodo.Checked = true;
                 }
                if (Nodo.HasChildren) { ChequearEnConsulta(Consulta, Nodo); }                
            }
        }
    }
}

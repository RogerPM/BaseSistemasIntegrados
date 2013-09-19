using System;
using System.Collections;
using System.Windows.Forms;

namespace ComboxExtended
{

    /// <summary>
    /// Collections of ComboBoxItem.
    /// </summary>
    /// <typeparam name="TComboBoxItem">ComboBoxItem.</typeparam>
    public class ComboCollection<TComboBoxItem> : CollectionBase
    {

        public EventHandler UpdateItems;
        public ComboBox.ObjectCollection ItemsBase { get; set; }

        public ItemCuadroCombinado this[int index]
        {
            get
            {
                return ((ItemCuadroCombinado)ItemsBase[index]);
            }
            set
            {
                ItemsBase[index] = value;
            }
        }

        public int Add(ItemCuadroCombinado value)
        {
            var result = ItemsBase.Add(value);
            UpdateItems.Invoke(this, null);
            return result;
        }

        public int IndexOf(ItemCuadroCombinado value)
        {
            return (ItemsBase.IndexOf(value));
        }

        public void Insert(int index, ItemCuadroCombinado value)
        {
            ItemsBase.Insert(index, value);
            UpdateItems.Invoke(this, null);
        }

        public void Remove(ItemCuadroCombinado value)
        {
            ItemsBase.Remove(value);
            UpdateItems.Invoke(this, null);
        }

        public bool Contains(ItemCuadroCombinado value)
        {
            return (ItemsBase.Contains(value));
        }

    }

}
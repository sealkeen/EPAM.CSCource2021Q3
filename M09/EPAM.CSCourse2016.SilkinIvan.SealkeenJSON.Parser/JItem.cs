using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EPAM.CSCourse2016.SilkinIvan.JSONParser
{
    //Represents the structure of a JSON document
    public abstract class JItem
    {
        protected List<JItem> Items;
        public JItem Parent = null;
        bool built = false;
        public JItem(JItem parent = null)
        {
            Parent = parent;
        }
        public bool ToFile(string filename, bool rewrite = false)
        {
            StreamWriter sW;
            if (File.Exists(filename) && rewrite)
            {
                sW =  new StreamWriter(filename, !rewrite);
            }
            sW = new StreamWriter(filename, rewrite);
            sW.Write(ToString());
            sW.Close();
            return true;
        }
        public void ListAllNodes(ref List<JItem> nodes)
        {
            if (Items == null)
            {
                Items = new List<JItem>();
            }
            foreach (var jItem in Items)
            {
                jItem.ListAllNodes(ref nodes);
                nodes.Add(jItem);
            }
        }
        public JItem FindUpperItemWithNode(JString jString)
        {
            while (this.Parent != null) {
                if (this.Contains(jString))
                    return this;
                else
                    this.Parent.FindUpperItemWithNode(jString);
            }
            return new JString("Item not found");
        }
        public virtual bool Equals(JItem jitem)
        {
            return false;
        }
        public virtual bool Contains(JSingleValue jItem)
        {
            return false;
        }
        public virtual bool HasItems()
        {
            return false;
        }
        public virtual bool HasKeyOrValue()
        {
            return false;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            BuildString(ref builder);
            return builder.ToString();
        }
        public virtual void BuildString(ref StringBuilder builder)
        {
            BuildString(ref builder);
        }
    }
}

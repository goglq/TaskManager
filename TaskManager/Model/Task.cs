using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TaskManager.Model
{
    public enum TaskType : int
    {
        Job,
        Study,
        Family,
        Home
    }

    public class Task
    {
        public TaskType TaskType { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }

        public XElement ToXml() => new XElement(
            "task",
            new XElement("title", Title),
            new XElement("type", (int)TaskType),
            new XElement("note", Note));

        public static Model.Task FromXml(XElement node) => 
            new Model.Task()
            {
                Title = (string)node.Element("title"),
                Note = (string)node.Element("note"),
                TaskType = (TaskType)(int)node.Element("type")
            };
    }
}

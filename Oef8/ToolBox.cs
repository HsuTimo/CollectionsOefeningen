using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef8
{
    public class ToolBox:IEnumerable
    {
        public int MaxWeight { get; private set; }
        private int _totalWeight { get; set; }
        private Dictionary<string,Tool> _tools { get; set; }
        public ToolBox(int maxWeight)
        {
            MaxWeight = maxWeight;
            _tools = new Dictionary<string, Tool>();
            _totalWeight = 0;
        }
        public void Add(Tool tool)
        {
            if (tool.Weight+_totalWeight<=MaxWeight)
            {
                _tools.Add(tool.Name,tool);
                _totalWeight += tool.Weight;
            }
            else
            {
                Console.WriteLine("Can't add more tools, because the toolbox has reached it's maximum weight!");
            }
        }
        public void Remove(string toolName)
        {
            if (_tools.ContainsKey(toolName))
            {
                _totalWeight -= _tools[toolName].Weight;
                _tools.Remove(toolName);
            }
            else
            {
                Console.WriteLine($"Can't find {toolName} in the toolbox, so it can't be removed");
            }
            
        }
        public int GetTotalTwoHandedHammerWeight()
        {
            int weight = 0;
            foreach (var item in _tools.Values.Where(x=>x is Hammer))
            {
                if (((Hammer)item).IsTwoHanded)
                {
                    weight += item.Weight;
                }
            }
            return weight;
        }

        public IEnumerator GetEnumerator()
        {
            return _tools.Values.GetEnumerator();
        }
    }
}

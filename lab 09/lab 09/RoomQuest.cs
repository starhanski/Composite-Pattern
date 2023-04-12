using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_09
{
    interface IComponent
    {
        void Display();
    }

    // Листки - окремі елементи квесту
    class Toy : IComponent
    {
        private string name;

        public Toy(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            MessageBox.Show($"Іграшка: {name}");
        }
    }

    class Furniture : IComponent
    {
        private string name;

        public Furniture(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            MessageBox.Show($"Меблі: {name}");
        }
    }

    public class Picture : IComponent
    {
        private string name;

        public Picture(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            MessageBox.Show($"Картинка: {name}");
        }
    }


    class RoomQuest : IComponent
    {
        private List<IComponent> components = new List<IComponent>();

        public void Add(IComponent component)
        {
            components.Add(component);
        }

        public void Remove(IComponent component)
        {
            components.Remove(component);
        }

        public void Display()
        {
            foreach (IComponent component in components)
            {
                component.Display();
            }
        }
    }
}

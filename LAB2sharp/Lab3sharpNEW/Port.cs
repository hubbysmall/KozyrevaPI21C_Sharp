using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3sharpNEW
{
    class Port
    {
       List<Docks<ITransport>> port;

        int countDocks = 20;
        int DockWidth = 210;
        int DockHeight = 100;
        int currentDock;

        public int getCurrentDock { get { return currentDock; } }

        public Port(int countStages)
        {
            port = new List<Docks<ITransport>>(countStages);
            for(int i=0; i<countStages; i++)
            {
                Docks<ITransport> oneDockStage = new Docks<ITransport>(20,null);
                port.Add(oneDockStage);
            }
        }

        public int PutInDock(ITransport ship)
        {
            return port[currentDock] + ship;
        }

        public ITransport PutOutDock(int dockNumber)
        {
            return port[currentDock] - dockNumber;
        }

        public void LevelUp() {
            if (currentDock + 1 < port.Count)
                currentDock++;
        }

        public void LevelDown() {
            if (currentDock > 0)
                currentDock--;
        }

        public void DrawDocks(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 4);
            g.DrawString("L" + (currentDock), new Font("Arial", 30), new SolidBrush(Color.Blue), (countDocks / 5) * DockWidth - 70, 420);
            g.DrawRectangle(pen, 0, 0, (countDocks / 5) * DockWidth, 480);
            for(int i=0; i < countDocks / 5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    g.DrawLine(pen, i * DockWidth, j * DockHeight, i * DockWidth + 110, j * DockHeight);
                    if (j < 4)
                    {
                        g.DrawString((i * 5 + j ).ToString(), new Font("Arial", 30), new SolidBrush(Color.Blue), i * DockWidth + 30, j * DockHeight + 20);
                    }
                }
                g.DrawLine(pen, i * DockWidth, 0, i * DockWidth, 400);
            }
         
        }

        public void DrawItAll(Graphics g, int width, int height)
        {
            DrawDocks(g);
            for (int i = 0; i < countDocks; i++)
            {
                var ship = port[currentDock][i];
                if (ship != null)
                {         
                    ship.setPosition(5 + i / 5 * DockWidth + 5, i % 5 * DockHeight + 45);
                    ship.drawBoat(g);
                }             
            }
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using(BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("CountLeveles:" +
                        port.Count + Environment.NewLine);
                    fs.Write(info, 0, info.Length);
                    foreach(var stage in port)
                    {
                        info = new UTF8Encoding(true).GetBytes("Level" + Environment.NewLine);
                        fs.Write(info, 0, info.Length);
                        for(int i=0; i<countDocks; i++)
                        {
                            var boat = stage[i];
                            if (boat != null)
                            {
                                if(boat.GetType().Name == "Boat")
                                {
                                    info = new UTF8Encoding(true).GetBytes("Boat:");
                                    fs.Write(info, 0, info.Length);
                                }
                                if (boat.GetType().Name == "Sailing_ship")
                                {
                                    info = new UTF8Encoding(true).GetBytes("Sailing_ship:");
                                    fs.Write(info, 0, info.Length);
                                }
                                info = new UTF8Encoding(true).GetBytes(boat.getInfo() + Environment.NewLine);
                                fs.Write(info, 0, info.Length);
                            }
                        }
                    }
                }
            }
                return true;
        }
        
        public bool LoadData(string filename)
        {
            
            if (!File.Exists(filename))
            {
                return false;
            }
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                string s = "";
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        s += temp.GetString(b);
                    }
                }
                s = s.Replace("\r", "");
                var strs = s.Split('\n');
                if (strs[0].Contains("CountLeveles"))
                {//Считываем количество уровней
                    int count = Convert.ToInt32(strs[0].Split(':')[1]);
                    if (port != null)
                    {
                        port.Clear();
                    }
                    port = new List<Docks<ITransport>>(count);
                }
                else
                {
                    return false;
                }
                int counter = -1;
                for (int i = 1; i < strs.Length; ++i)
                {//шагаем по считанным записям
                    if (strs[i] == "Level")
                    {//начинаем новый уровень
                        counter++;
                        port.Add(new Docks<ITransport>(countDocks, null));
                    }
                    else if (strs[i].Split(':')[0] == "Boat")
                    {
                        ITransport boat = new Boat(strs[i].Split(':')[1]);
                        int number = port[counter] + boat;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                    else if (strs[i].Split(':')[0] == "Sailing_ship")
                    {
                        ITransport boat = new Sailing_ship(strs[i].Split(':')[1]);
                        int number = port[counter] + boat;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        } 

    }
}

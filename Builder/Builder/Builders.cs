using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Builders
    {
        /// "roomWidth" Ширина комнаты
        /// "roomLength" Длина комнаты 
        /// "roomHeight" Высота комнаты 
        /// "windowWidth" Ширина окна 
        /// "windowHeight" Высота окна 
        /// "doorWidth" Ширина дверного проёма 
        /// "doorHeight" Высота дверного проёма
        /// "rollWidth" Ширина рулона обоев
        public int PasteWallpaper(double roomWidth, double roomLength, double roomHeight, double windowWidth, double windowHeight, double doorWidth, double doorHeight, double rollWidth)
        {
            // Площадь стен (ПЕРИМЕТР * ВЫСОТУ)
            double wallsArea = 2 * (roomWidth + roomLength) * roomHeight;

            // Вычитаем площадь окна и двери
            double windowArea = windowWidth * windowHeight;
            double doorArea = doorWidth * doorHeight;
            double totalArea = wallsArea - windowArea - doorArea;

            // Площадь одного рулона (ДЛИНА * ШИРИНА)
            double rollArea = 10.5 * rollWidth;

            // Рассчитываем количество рулонов
            int rollsNeeded = (int)Math.Ceiling(totalArea / rollArea);
            return rollsNeeded;
        }
        /// "roomWidth" Ширина комнаты
        /// "roomLength" Длина комнаты 
        /// "linoleumWidth" Ширина рулона линолеума 
        public double LayLinoleum(double roomWidth, double roomLength, double linoleumWidth)
        {
            // Площадь комнаты
            double roomArea = roomWidth * roomLength;

            // Длина линолеума (ПЛОЩАДЬ / ШИРИНА)
            double linoleumLength = roomArea / linoleumWidth;
            return linoleumLength;
        }
        /// "roomWidth" Ширина комнаты 
        /// "roomLength" Длина комнаты
        /// "paintLoss" Расход краски на 1 кв/m
        /// "canValue" Объем одной банки краски
        public int CeilingPainting(double roomWidth, double roomLength, double paintLoss, double canValue)
        {
            // Площадь потолка
            double ceilingArea = roomWidth * roomLength;

            // Общий необходимый объем краски
            double paintVolumeNeeded = ceilingArea * paintLoss;

            // Рассчитываем количество банок
            int cansNeeded = (int)Math.Ceiling(paintVolumeNeeded / canValue);
            return cansNeeded;
        }
    }
}

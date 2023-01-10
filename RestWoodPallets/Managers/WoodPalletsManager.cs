using System.Xml.Linq;
using WoodPalletsLib;

namespace RestWoodPallets.Managers
{
    public class WoodPalletsManager
    {
        public static List<WododPallet> WoodPalletsList = new List<WododPallet>()
        {
            new WododPallet(1, "Mortensens", 800, 3),
            new WododPallet(2, "Woodlets", 100, 1),
            new WododPallet(3, "Woodenheimer", 1300, 5),
            new WododPallet(4, "Wooster", 2000, 5),
            new WododPallet(5, "Pallettes", 900, 4),
            new WododPallet(6, "Hello", 600, 2)
        };

        public List<WododPallet> GetAll()
        {
            return WoodPalletsList;
        }

        public WododPallet GetById(int id) 
        {
            return WoodPalletsList.Find(woodpallet => woodpallet.Id == id);
        }

        public WododPallet Add(WododPallet newWoodPallet)
        {
            newWoodPallet.Id = WoodPalletsList.Count + 1;
            WoodPalletsList.Add(newWoodPallet);
            return newWoodPallet;
        }

        public WododPallet Update(int id)
        {
            WododPallet? woodpallet = WoodPalletsList.Find(woodpallet => woodpallet.Id == id);
            if (woodpallet == null) return null;
            return woodpallet;
        }
    }
}

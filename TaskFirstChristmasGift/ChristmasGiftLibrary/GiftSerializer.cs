using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChristmasGiftLibrary
{
    public class GiftSerializer
    {
        private readonly BinaryFormatter _formatter = new BinaryFormatter();
        private FileStream _fs;
        
        public void SerializeGift(ChristmasGift gift, string giftName)
        {
            try 
            {
                _fs = new FileStream(giftName, FileMode.Create);
                _formatter.Serialize(_fs, gift);
            }
            catch (Exception e)
            {
                Debug.Fail(e.Message);
            }
            finally
            {
                if (_fs != null) _fs.Close();
            }
        }

        public ChristmasGift DeserializeGift(ChristmasGift gift, string giftName)
        {
            try
            {
                _fs = new FileStream(giftName, FileMode.Open);
                gift = (ChristmasGift) _formatter.Deserialize(_fs);
            }
            catch (Exception e)
            {
                Debug.Fail(e.Message);
            }
            finally 
            {
                if (_fs != null) _fs.Close();
            }
            return gift;
        }
    }
}

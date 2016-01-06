using System.IO;

namespace RPON.Packet
{
    public class Data
    {
        public int type;
        public bool comp;
        public int dataSize;
        public byte[] dataBytes;
        public int bx;
        public int by;
        public int bwidth;
        public int bheight;

        public Data()
        {
            this.type = 0;
            this.comp = false;
            this.dataBytes = new byte[5];
            this.dataSize = 0;
            this.bx = 0;
            this.by = 0;
            this.bwidth = 0;
            this.bheight = 0;
        }

        public byte[] Serialize()
        {
            using (MemoryStream m = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(m))
                {
                    writer.Write(type);
                    writer.Write(comp);
                    writer.Write(bx);
                    writer.Write(by);
                    writer.Write(bwidth);
                    writer.Write(bheight);
                    writer.Write(dataSize);
                    writer.Write(dataBytes);
                }
                return m.ToArray();
            }
        }

        public static Data Desserialize(byte[] data)
        {
            Data result = new Data();
            using (MemoryStream m = new MemoryStream(data))
            {
                using (BinaryReader reader = new BinaryReader(m))
                {
                    result.type = reader.ReadInt32();
                    result.comp = reader.ReadBoolean();
                    result.bx = reader.ReadInt32();
                    result.by = reader.ReadInt32();
                    result.bwidth = reader.ReadInt32();
                    result.bheight = reader.ReadInt32();
                    result.dataSize = reader.ReadInt32();
                    result.dataBytes = reader.ReadBytes(result.dataSize);
                }
            }
            return result;
        }
    }
}

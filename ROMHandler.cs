using System;
using System.IO;

namespace ScriptTool
{
    class ROMHandler
    {
        FileStream   ROM;
        MemoryStream Mem;
        BinaryReader InputBinary;
        BinaryWriter OutputBinary;
        bool ROMChanged { get; set; }

        public ROMHandler()
        {
            ROMChanged = false;
        }

        public void OpenROM(string FileName)
        {
            ROM = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            Mem = new MemoryStream();
            ROM.CopyTo(Mem);
            ROM.Close();

            InputBinary  = new BinaryReader(Mem);
            OutputBinary = new BinaryWriter(Mem);

            ROMChanged = false; 
        }

        public void SaveROM(string FileName)
        {
            ROM.Close();
            ROM = new FileStream(FileName, FileMode.Open, FileAccess.Write);
            Mem.WriteTo(ROM);
        }

        public void CloseROM()
        {
            if (ROM != null)
                ROM.Close();
            if (Mem != null)
                Mem.Close();
        }

        public void SeekROM(int FileOffset)
        {
            if (Mem != null)
                Mem.Seek(FileOffset, SeekOrigin.Begin);
        }

        public bool IsOpen()
        {
            return Mem != null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRC16
{
    public partial class MainForm : Form
    {
        protected ushort[] CRCTbl { get; set; }
        protected ushort CRC16 { get; set; }

        public MainForm()
        {
            InitializeComponent();
            InitCRCTable();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtData.Text.Length == 0)
            {
                MessageBox.Show("You must enter a data string!", "CRC16", MessageBoxButtons.OK);
            }

            if (!txtData.Text.Contains(","))
            {
                MessageBox.Show("Your data string must be comma delimited!", "CRC16", MessageBoxButtons.OK);
            }

            var data = GetData();
            if (data.Length > 0)
            {
                ushort checksum = TestCRC(data);

                lblChecksum.Text = checksum.ToString();
                byte byte1 = (byte)((checksum >> 8) & 0xff);
                byte byte2 = (byte)(checksum & 0xff);

                byte[] bytes = new byte[] { byte1 };
                lblByte1.Text = BitConverter.ToString(bytes);
                bytes = new byte[] { byte2 };
                lblByte2.Text = BitConverter.ToString(bytes);

            }
        }

        private byte[] GetData()
        {
            var stringData = txtData.Text;
            stringData = stringData.Replace(",", "");

            int NumberChars = stringData.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(stringData.Substring(i, 2), 16);
            return bytes;
        }

        /// <summary>
        /// Entry point for verification of the CRC-CCITT on a stream of bytes.
        /// </summary>
        /// <param name="stream">A byte[] of data to be calculated.</param>
        /// <returns>The CRC for the input stream.</returns>
        public ushort TestCRC(byte[] stream)
        {
            var s = new StreamWriter(@"c:\temp\crc456.txt");
            InitCRC();
            ushort crc = CRC16;
            foreach (byte t in stream)
            {
                crc = CRC_16_CCITT(t);
                s.WriteLine(crc);
            }
            s.Flush();
            s.Close();
            return crc;
        }

        //*********************************************************************************
        //
        // The following 3 functions were taken from lib_crc.c written by
        // Lammert Bies and available from http://www.lammertbies.nl/download/lib_crc.zip
        // as a free download with source.
        //
        //*********************************************************************************
        /// <summary>
        /// Calculate the CRC-16 value for the next byte
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <param name="next">The next byte</param>
        /// <returns>The updated CRC value.</returns>
        private ushort CRC_16_CCITT(byte next)
        {
            ushort shortC = (ushort)(0x00ff & next);
            ushort tmp = (ushort)((CRC16 >> 8) ^ shortC);
            CRC16 = (ushort)((CRC16 << 8) ^ CRCTbl[tmp]);

            return CRC16;
        }

        /// <summary>
        /// Initialize the CRC seed value to -1
        /// </summary>
        private void InitCRC()
        {
            CRC16 = 0xffff;
        }

        /// <summary>
        /// Initialize the CRC table.
        /// </summary>
        private void InitCRCTable()
        {
            CRC16 = 0xffff;
            CRCTbl = new ushort[256];

            int i;
            const ushort POLY = 0x1021;

            for (i = 0; i < 256; i++)
            {
                ushort crc = 0;
                ushort c = (ushort)(((ushort)i) << 8);
                int j;
                for (j = 0; j < 8; j++)
                {
                    if (((crc ^ c) & 0x8000) != 0)
                    {
                        crc = (ushort)((crc << 1) ^ POLY);
                    }
                    else
                    {
                        crc = (ushort)(crc << 1);
                    }
                    c = (ushort)(c << 1);
                }

                CRCTbl[i] = crc;
            }
        }
    }
}

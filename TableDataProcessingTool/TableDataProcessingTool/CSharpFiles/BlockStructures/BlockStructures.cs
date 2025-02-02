using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableDataProcessingTool.CSharpFiles
{
    [Serializable]
    public class BlockStructures : BaseClass
    {
        //    Data Construction Test
        private List<KeyValuePair<BlockStructures, BlockStructures>> DCTMapping = new List<KeyValuePair<BlockStructures, BlockStructures>>();
        
        private List<BlockStructure> BlockStructureList;
        
        public BlockStructures()
        {
            this.BlockStructureList = new List<BlockStructure>();
            DCTMappingInitializer();
        }

        public BlockStructures(List<BlockStructure> NewBlockStructureList)
        {
            this.BlockStructureList = NewBlockStructureList;
        }

        public BlockStructures(string Command, BlockStructures InputParameters)
        {
            if (Command.Equals("DCT"))            //    Data Construction Test
            {
                
                
                

            }
        }

        private void DCTMappingInitializer()
        {
            this.DCTMapping.AddRange(DCT888());
        }

        private List<KeyValuePair<BlockStructures, BlockStructures>> DCT888()
        {
            List<KeyValuePair<BlockStructures, BlockStructures>> ReturnObject =
                new List<KeyValuePair<BlockStructures, BlockStructures>>();

            //    Construct known data
            string LowerBound = "00000000";
            string UpperBound = "11111111";

            List<BlockStructure> KeyCubeList = new List<BlockStructure>();
            for (int LoopNumber = 0; LoopNumber < 8; LoopNumber++)
            {
                if (LoopNumber % 2 == 0)
                {
                    //    Reference: https://stackoverflow.com/a/9149738/6667035
                    KeyCubeList.Add(new BlockStructure(8, 8).SetCell(new CellStructure(Convert.ToInt32(LowerBound, 2).ToString())).Item2);
                }
                else
                {
                    //    Reference: https://stackoverflow.com/a/9149738/6667035
                    KeyCubeList.Add(new BlockStructure(8, 8).SetCell(new CellStructure(Convert.ToInt32(UpperBound, 2).ToString())).Item2);
                }
            }

            List<BlockStructure> ValueCubeList = new List<BlockStructure>();
            ValueCubeList.Add(new BlockStructure(8, 8)
                .SetCell(new CellStructure("360.624"), new Tuple<int, int>(0, 0)).Item2
                .SetCell(new CellStructure("2.81997E-14"), new Tuple<int, int>(1, 0)).Item2
                .SetCell(new CellStructure("-2.88658E-14"), new Tuple<int, int>(2, 0)).Item2
                .SetCell(new CellStructure("4.24105E-14"), new Tuple<int, int>(3, 0)).Item2
                .SetCell(new CellStructure("1.42109E-14"), new Tuple<int, int>(4, 0)).Item2
                .SetCell(new CellStructure("-2.84217E-14"), new Tuple<int, int>(5, 0)).Item2
                .SetCell(new CellStructure("-2.77001E-13"), new Tuple<int, int>(6, 0)).Item2
                .SetCell(new CellStructure("4.26437E-13"), new Tuple<int, int>(7, 0)).Item2
                .SetCell(new CellStructure("3.10862E-15"), new Tuple<int, int>(0, 1)).Item2
                .SetCell(new CellStructure("3.14018E-16"), new Tuple<int, int>(1, 1)).Item2
                .SetCell(new CellStructure("6.28037E-16"), new Tuple<int, int>(2, 1)).Item2
                .SetCell(new CellStructure("2.51215E-15"), new Tuple<int, int>(3, 1)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(4, 1)).Item2
                .SetCell(new CellStructure("-1.25607E-15"), new Tuple<int, int>(5, 1)).Item2
                .SetCell(new CellStructure("1.57009E-16"), new Tuple<int, int>(6, 1)).Item2
                .SetCell(new CellStructure("-1.17757E-15"), new Tuple<int, int>(7, 1)).Item2
                .SetCell(new CellStructure("-1.46549E-14"), new Tuple<int, int>(0, 2)).Item2
                .SetCell(new CellStructure("9.42055E-15"), new Tuple<int, int>(1, 2)).Item2
                .SetCell(new CellStructure("-3.14018E-16"), new Tuple<int, int>(2, 2)).Item2
                .SetCell(new CellStructure("2.19813E-15"), new Tuple<int, int>(3, 2)).Item2
                .SetCell(new CellStructure("-2.19813E-15"), new Tuple<int, int>(4, 2)).Item2
                .SetCell(new CellStructure("-3.14018E-16"), new Tuple<int, int>(5, 2)).Item2
                .SetCell(new CellStructure("1.25607E-15"), new Tuple<int, int>(6, 2)).Item2
                .SetCell(new CellStructure("1.17757E-15"), new Tuple<int, int>(7, 2)).Item2
                .SetCell(new CellStructure("7.10543E-14"), new Tuple<int, int>(0, 3)).Item2
                .SetCell(new CellStructure("-9.42055E-16"), new Tuple<int, int>(1, 3)).Item2
                .SetCell(new CellStructure("5.0243E-15"), new Tuple<int, int>(2, 3)).Item2
                .SetCell(new CellStructure("-3.14018E-16"), new Tuple<int, int>(3, 3)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(4, 3)).Item2
                .SetCell(new CellStructure("2.51215E-15"), new Tuple<int, int>(5, 3)).Item2
                .SetCell(new CellStructure("2.51215E-15"), new Tuple<int, int>(6, 3)).Item2
                .SetCell(new CellStructure("1.25607E-15"), new Tuple<int, int>(7, 3)).Item2
                .SetCell(new CellStructure("2.13163E-14"), new Tuple<int, int>(0, 4)).Item2
                .SetCell(new CellStructure("6.28037E-16"), new Tuple<int, int>(1, 4)).Item2
                .SetCell(new CellStructure("-5.0243E-15"), new Tuple<int, int>(2, 4)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(3, 4)).Item2
                .SetCell(new CellStructure("-2.51215E-15"), new Tuple<int, int>(4, 4)).Item2
                .SetCell(new CellStructure("-1.09906E-15"), new Tuple<int, int>(5, 4)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(6, 4)).Item2
                .SetCell(new CellStructure("-1.41308E-15"), new Tuple<int, int>(7, 4)).Item2
                .SetCell(new CellStructure("-5.01821E-14"), new Tuple<int, int>(0, 5)).Item2
                .SetCell(new CellStructure("-5.65233E-15"), new Tuple<int, int>(1, 5)).Item2
                .SetCell(new CellStructure("4.71028E-15"), new Tuple<int, int>(2, 5)).Item2
                .SetCell(new CellStructure("2.82617E-15"), new Tuple<int, int>(3, 5)).Item2
                .SetCell(new CellStructure("-1.57009E-16"), new Tuple<int, int>(4, 5)).Item2
                .SetCell(new CellStructure("-5.0243E-15"), new Tuple<int, int>(5, 5)).Item2
                .SetCell(new CellStructure("1.17757E-15"), new Tuple<int, int>(6, 5)).Item2
                .SetCell(new CellStructure("-1.13832E-15"), new Tuple<int, int>(7, 5)).Item2
                .SetCell(new CellStructure("-2.6934E-13"), new Tuple<int, int>(0, 6)).Item2
                .SetCell(new CellStructure("-4.39626E-15"), new Tuple<int, int>(1, 6)).Item2
                .SetCell(new CellStructure("5.49532E-15"), new Tuple<int, int>(2, 6)).Item2
                .SetCell(new CellStructure("1.57009E-16"), new Tuple<int, int>(3, 6)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(4, 6)).Item2
                .SetCell(new CellStructure("1.09906E-15"), new Tuple<int, int>(5, 6)).Item2
                .SetCell(new CellStructure("2.51215E-15"), new Tuple<int, int>(6, 6)).Item2
                .SetCell(new CellStructure("-1.25607E-15"), new Tuple<int, int>(7, 6)).Item2
                .SetCell(new CellStructure("4.39315E-13"), new Tuple<int, int>(0, 7)).Item2
                .SetCell(new CellStructure("1.33458E-15"), new Tuple<int, int>(1, 7)).Item2
                .SetCell(new CellStructure("9.42055E-16"), new Tuple<int, int>(2, 7)).Item2
                .SetCell(new CellStructure("2.51215E-15"), new Tuple<int, int>(3, 7)).Item2
                .SetCell(new CellStructure("-1.02056E-15"), new Tuple<int, int>(4, 7)).Item2
                .SetCell(new CellStructure("-1.41308E-15"), new Tuple<int, int>(5, 7)).Item2
                .SetCell(new CellStructure("-2.74766E-16"), new Tuple<int, int>(6, 7)).Item2
                .SetCell(new CellStructure("-3.76822E-15"), new Tuple<int, int>(7, 7)).Item2
            );
            ValueCubeList.Add(new BlockStructure(8, 8)
                .SetCell(new CellStructure("-64.9989"), new Tuple<int, int>(0, 0)).Item2
                .SetCell(new CellStructure("-7.22243E-15"), new Tuple<int, int>(1, 0)).Item2
                .SetCell(new CellStructure("8.79252E-15"), new Tuple<int, int>(2, 0)).Item2
                .SetCell(new CellStructure("-2.51215E-15"), new Tuple<int, int>(3, 0)).Item2
                .SetCell(new CellStructure("-1.25607E-15"), new Tuple<int, int>(4, 0)).Item2
                .SetCell(new CellStructure("5.65233E-15"), new Tuple<int, int>(5, 0)).Item2
                .SetCell(new CellStructure("5.66803E-14"), new Tuple<int, int>(6, 0)).Item2
                .SetCell(new CellStructure("-7.87401E-14"), new Tuple<int, int>(7, 0)).Item2
                .SetCell(new CellStructure("-6.28037E-15"), new Tuple<int, int>(0, 1)).Item2
                .SetCell(new CellStructure("-3.55271E-15"), new Tuple<int, int>(1, 1)).Item2
                .SetCell(new CellStructure("-8.88178E-16"), new Tuple<int, int>(2, 1)).Item2
                .SetCell(new CellStructure("8.88178E-16"), new Tuple<int, int>(3, 1)).Item2
                .SetCell(new CellStructure("8.88178E-16"), new Tuple<int, int>(4, 1)).Item2
                .SetCell(new CellStructure("-8.88178E-16"), new Tuple<int, int>(5, 1)).Item2
                .SetCell(new CellStructure("-1.33227E-15"), new Tuple<int, int>(6, 1)).Item2
                .SetCell(new CellStructure("-6.66134E-16"), new Tuple<int, int>(7, 1)).Item2
                .SetCell(new CellStructure("3.51701E-14"), new Tuple<int, int>(0, 2)).Item2
                .SetCell(new CellStructure("1.77636E-15"), new Tuple<int, int>(1, 2)).Item2
                .SetCell(new CellStructure("4.44089E-16"), new Tuple<int, int>(2, 2)).Item2
                .SetCell(new CellStructure("-2.66454E-15"), new Tuple<int, int>(3, 2)).Item2
                .SetCell(new CellStructure("4.44089E-16"), new Tuple<int, int>(4, 2)).Item2
                .SetCell(new CellStructure("8.88178E-16"), new Tuple<int, int>(5, 2)).Item2
                .SetCell(new CellStructure("2.22045E-16"), new Tuple<int, int>(6, 2)).Item2
                .SetCell(new CellStructure("3.33067E-16"), new Tuple<int, int>(7, 2)).Item2
                .SetCell(new CellStructure("2.07252E-14"), new Tuple<int, int>(0, 3)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(1, 3)).Item2
                .SetCell(new CellStructure("-4.44089E-15"), new Tuple<int, int>(2, 3)).Item2
                .SetCell(new CellStructure("2.22045E-15"), new Tuple<int, int>(3, 3)).Item2
                .SetCell(new CellStructure("4.44089E-16"), new Tuple<int, int>(4, 3)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(5, 3)).Item2
                .SetCell(new CellStructure("-1.77636E-15"), new Tuple<int, int>(6, 3)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(7, 3)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(0, 4)).Item2
                .SetCell(new CellStructure("1.77636E-15"), new Tuple<int, int>(1, 4)).Item2
                .SetCell(new CellStructure("1.33227E-15"), new Tuple<int, int>(2, 4)).Item2
                .SetCell(new CellStructure("1.33227E-15"), new Tuple<int, int>(3, 4)).Item2
                .SetCell(new CellStructure("-8.88178E-16"), new Tuple<int, int>(4, 4)).Item2
                .SetCell(new CellStructure("-2.22045E-16"), new Tuple<int, int>(5, 4)).Item2
                .SetCell(new CellStructure("-1.33227E-15"), new Tuple<int, int>(6, 4)).Item2
                .SetCell(new CellStructure("4.44089E-16"), new Tuple<int, int>(7, 4)).Item2
                .SetCell(new CellStructure("1.00486E-14"), new Tuple<int, int>(0, 5)).Item2
                .SetCell(new CellStructure("1.77636E-15"), new Tuple<int, int>(1, 5)).Item2
                .SetCell(new CellStructure("-8.88178E-16"), new Tuple<int, int>(2, 5)).Item2
                .SetCell(new CellStructure("1.33227E-15"), new Tuple<int, int>(3, 5)).Item2
                .SetCell(new CellStructure("-1.11022E-15"), new Tuple<int, int>(4, 5)).Item2
                .SetCell(new CellStructure("2.22045E-16"), new Tuple<int, int>(5, 5)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(6, 5)).Item2
                .SetCell(new CellStructure("-7.21645E-16"), new Tuple<int, int>(7, 5)).Item2
                .SetCell(new CellStructure("5.80934E-14"), new Tuple<int, int>(0, 6)).Item2
                .SetCell(new CellStructure("-1.33227E-15"), new Tuple<int, int>(1, 6)).Item2
                .SetCell(new CellStructure("-1.77636E-15"), new Tuple<int, int>(2, 6)).Item2
                .SetCell(new CellStructure("-1.9984E-15"), new Tuple<int, int>(3, 6)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(4, 6)).Item2
                .SetCell(new CellStructure("-1.11022E-16"), new Tuple<int, int>(5, 6)).Item2
                .SetCell(new CellStructure("-9.99201E-16"), new Tuple<int, int>(6, 6)).Item2
                .SetCell(new CellStructure("8.32667E-16"), new Tuple<int, int>(7, 6)).Item2
                .SetCell(new CellStructure("-7.96037E-14"), new Tuple<int, int>(0, 7)).Item2
                .SetCell(new CellStructure("1.33227E-15"), new Tuple<int, int>(1, 7)).Item2
                .SetCell(new CellStructure("3.33067E-15"), new Tuple<int, int>(2, 7)).Item2
                .SetCell(new CellStructure("-7.77156E-16"), new Tuple<int, int>(3, 7)).Item2
                .SetCell(new CellStructure("1.11022E-16"), new Tuple<int, int>(4, 7)).Item2
                .SetCell(new CellStructure("4.44089E-16"), new Tuple<int, int>(5, 7)).Item2
                .SetCell(new CellStructure("1.38778E-15"), new Tuple<int, int>(6, 7)).Item2
                .SetCell(new CellStructure("-9.71445E-16"), new Tuple<int, int>(7, 7)).Item2
            );
            ValueCubeList.Add(new BlockStructure(8, 8)
                .SetCell(new CellStructure("-4.74731E-13"), new Tuple<int, int>(0, 0)).Item2
                .SetCell(new CellStructure("-6.28037E-16"), new Tuple<int, int>(1, 0)).Item2
                .SetCell(new CellStructure("3.14018E-16"), new Tuple<int, int>(2, 0)).Item2
                .SetCell(new CellStructure("4.71028E-15"), new Tuple<int, int>(3, 0)).Item2
                .SetCell(new CellStructure("-3.76822E-15"), new Tuple<int, int>(4, 0)).Item2
                .SetCell(new CellStructure("-3.76822E-15"), new Tuple<int, int>(5, 0)).Item2
                .SetCell(new CellStructure("3.14018E-15"), new Tuple<int, int>(6, 0)).Item2
                .SetCell(new CellStructure("3.68972E-15"), new Tuple<int, int>(7, 0)).Item2
                .SetCell(new CellStructure("-4.52187E-14"), new Tuple<int, int>(0, 1)).Item2
                .SetCell(new CellStructure("3.55271E-15"), new Tuple<int, int>(1, 1)).Item2
                .SetCell(new CellStructure("8.88178E-16"), new Tuple<int, int>(2, 1)).Item2
                .SetCell(new CellStructure("-4.44089E-16"), new Tuple<int, int>(3, 1)).Item2
                .SetCell(new CellStructure("-8.88178E-16"), new Tuple<int, int>(4, 1)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(5, 1)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(6, 1)).Item2
                .SetCell(new CellStructure("-3.33067E-16"), new Tuple<int, int>(7, 1)).Item2
                .SetCell(new CellStructure("4.39626E-15"), new Tuple<int, int>(0, 2)).Item2
                .SetCell(new CellStructure("4.88498E-15"), new Tuple<int, int>(1, 2)).Item2
                .SetCell(new CellStructure("-1.33227E-15"), new Tuple<int, int>(2, 2)).Item2
                .SetCell(new CellStructure("8.88178E-16"), new Tuple<int, int>(3, 2)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(4, 2)).Item2
                .SetCell(new CellStructure("2.22045E-16"), new Tuple<int, int>(5, 2)).Item2
                .SetCell(new CellStructure("-4.44089E-16"), new Tuple<int, int>(6, 2)).Item2
                .SetCell(new CellStructure("-1.88738E-15"), new Tuple<int, int>(7, 2)).Item2
                .SetCell(new CellStructure("8.16448E-15"), new Tuple<int, int>(0, 3)).Item2
                .SetCell(new CellStructure("1.77636E-15"), new Tuple<int, int>(1, 3)).Item2
                .SetCell(new CellStructure("-1.77636E-15"), new Tuple<int, int>(2, 3)).Item2
                .SetCell(new CellStructure("8.88178E-16"), new Tuple<int, int>(3, 3)).Item2
                .SetCell(new CellStructure("-8.88178E-16"), new Tuple<int, int>(4, 3)).Item2
                .SetCell(new CellStructure("1.77636E-15"), new Tuple<int, int>(5, 3)).Item2
                .SetCell(new CellStructure("-2.22045E-16"), new Tuple<int, int>(6, 3)).Item2
                .SetCell(new CellStructure("7.77156E-16"), new Tuple<int, int>(7, 3)).Item2
                .SetCell(new CellStructure("6.28037E-16"), new Tuple<int, int>(0, 4)).Item2
                .SetCell(new CellStructure("-1.77636E-15"), new Tuple<int, int>(1, 4)).Item2
                .SetCell(new CellStructure("-1.33227E-15"), new Tuple<int, int>(2, 4)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(3, 4)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(4, 4)).Item2
                .SetCell(new CellStructure("-8.88178E-16"), new Tuple<int, int>(5, 4)).Item2
                .SetCell(new CellStructure("-1.44329E-15"), new Tuple<int, int>(6, 4)).Item2
                .SetCell(new CellStructure("1.88738E-15"), new Tuple<int, int>(7, 4)).Item2
                .SetCell(new CellStructure("-1.25607E-14"), new Tuple<int, int>(0, 5)).Item2
                .SetCell(new CellStructure("-8.88178E-16"), new Tuple<int, int>(1, 5)).Item2
                .SetCell(new CellStructure("3.77476E-15"), new Tuple<int, int>(2, 5)).Item2
                .SetCell(new CellStructure("1.9984E-15"), new Tuple<int, int>(3, 5)).Item2
                .SetCell(new CellStructure("-6.66134E-16"), new Tuple<int, int>(4, 5)).Item2
                .SetCell(new CellStructure("4.44089E-16"), new Tuple<int, int>(5, 5)).Item2
                .SetCell(new CellStructure("2.22045E-15"), new Tuple<int, int>(6, 5)).Item2
                .SetCell(new CellStructure("7.21645E-16"), new Tuple<int, int>(7, 5)).Item2
                .SetCell(new CellStructure("1.57009E-15"), new Tuple<int, int>(0, 6)).Item2
                .SetCell(new CellStructure("4.88498E-15"), new Tuple<int, int>(1, 6)).Item2
                .SetCell(new CellStructure("-2.22045E-16"), new Tuple<int, int>(2, 6)).Item2
                .SetCell(new CellStructure("1.33227E-15"), new Tuple<int, int>(3, 6)).Item2
                .SetCell(new CellStructure("-9.99201E-16"), new Tuple<int, int>(4, 6)).Item2
                .SetCell(new CellStructure("3.33067E-16"), new Tuple<int, int>(5, 6)).Item2
                .SetCell(new CellStructure("-1.44329E-15"), new Tuple<int, int>(6, 6)).Item2
                .SetCell(new CellStructure("-2.22045E-16"), new Tuple<int, int>(7, 6)).Item2
                .SetCell(new CellStructure("4.71028E-16"), new Tuple<int, int>(0, 7)).Item2
                .SetCell(new CellStructure("4.21885E-15"), new Tuple<int, int>(1, 7)).Item2
                .SetCell(new CellStructure("6.66134E-16"), new Tuple<int, int>(2, 7)).Item2
                .SetCell(new CellStructure("3.33067E-16"), new Tuple<int, int>(3, 7)).Item2
                .SetCell(new CellStructure("1.66533E-15"), new Tuple<int, int>(4, 7)).Item2
                .SetCell(new CellStructure("-5.55112E-17"), new Tuple<int, int>(5, 7)).Item2
                .SetCell(new CellStructure("2.77556E-16"), new Tuple<int, int>(6, 7)).Item2
                .SetCell(new CellStructure("-6.93889E-16"), new Tuple<int, int>(7, 7)).Item2
            );
            ValueCubeList.Add(new BlockStructure(8, 8)
                .SetCell(new CellStructure("-76.6715"), new Tuple<int, int>(0, 0)).Item2
                .SetCell(new CellStructure("2.82617E-15"), new Tuple<int, int>(1, 0)).Item2
                .SetCell(new CellStructure("1.19327E-14"), new Tuple<int, int>(2, 0)).Item2
                .SetCell(new CellStructure("-5.96635E-15"), new Tuple<int, int>(3, 0)).Item2
                .SetCell(new CellStructure("-3.76822E-15"), new Tuple<int, int>(4, 0)).Item2
                .SetCell(new CellStructure("6.90841E-15"), new Tuple<int, int>(5, 0)).Item2
                .SetCell(new CellStructure("5.95065E-14"), new Tuple<int, int>(6, 0)).Item2
                .SetCell(new CellStructure("-8.98093E-14"), new Tuple<int, int>(7, 0)).Item2
                .SetCell(new CellStructure("-3.14018E-14"), new Tuple<int, int>(0, 1)).Item2
                .SetCell(new CellStructure("2.22045E-15"), new Tuple<int, int>(1, 1)).Item2
                .SetCell(new CellStructure("-1.33227E-15"), new Tuple<int, int>(2, 1)).Item2
                .SetCell(new CellStructure("-4.44089E-16"), new Tuple<int, int>(3, 1)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(4, 1)).Item2
                .SetCell(new CellStructure("8.88178E-16"), new Tuple<int, int>(5, 1)).Item2
                .SetCell(new CellStructure("-2.22045E-16"), new Tuple<int, int>(6, 1)).Item2
                .SetCell(new CellStructure("6.66134E-16"), new Tuple<int, int>(7, 1)).Item2
                .SetCell(new CellStructure("2.51215E-14"), new Tuple<int, int>(0, 2)).Item2
                .SetCell(new CellStructure("-4.44089E-16"), new Tuple<int, int>(1, 2)).Item2
                .SetCell(new CellStructure("1.77636E-15"), new Tuple<int, int>(2, 2)).Item2
                .SetCell(new CellStructure("4.44089E-16"), new Tuple<int, int>(3, 2)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(4, 2)).Item2
                .SetCell(new CellStructure("6.66134E-16"), new Tuple<int, int>(5, 2)).Item2
                .SetCell(new CellStructure("-2.22045E-16"), new Tuple<int, int>(6, 2)).Item2
                .SetCell(new CellStructure("-5.55112E-16"), new Tuple<int, int>(7, 2)).Item2
                .SetCell(new CellStructure("-3.57981E-14"), new Tuple<int, int>(0, 3)).Item2
                .SetCell(new CellStructure("4.44089E-16"), new Tuple<int, int>(1, 3)).Item2
                .SetCell(new CellStructure("-2.66454E-15"), new Tuple<int, int>(2, 3)).Item2
                .SetCell(new CellStructure("-4.44089E-16"), new Tuple<int, int>(3, 3)).Item2
                .SetCell(new CellStructure("8.88178E-16"), new Tuple<int, int>(4, 3)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(5, 3)).Item2
                .SetCell(new CellStructure("-1.55431E-15"), new Tuple<int, int>(6, 3)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(7, 3)).Item2
                .SetCell(new CellStructure("-8.16448E-15"), new Tuple<int, int>(0, 4)).Item2
                .SetCell(new CellStructure("1.33227E-15"), new Tuple<int, int>(1, 4)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(2, 4)).Item2
                .SetCell(new CellStructure("1.55431E-15"), new Tuple<int, int>(3, 4)).Item2
                .SetCell(new CellStructure("1.55431E-15"), new Tuple<int, int>(4, 4)).Item2
                .SetCell(new CellStructure("-8.88178E-16"), new Tuple<int, int>(5, 4)).Item2
                .SetCell(new CellStructure("-4.44089E-16"), new Tuple<int, int>(6, 4)).Item2
                .SetCell(new CellStructure("-4.44089E-16"), new Tuple<int, int>(7, 4)).Item2
                .SetCell(new CellStructure("1.31888E-14"), new Tuple<int, int>(0, 5)).Item2
                .SetCell(new CellStructure("3.10862E-15"), new Tuple<int, int>(1, 5)).Item2
                .SetCell(new CellStructure("-1.11022E-15"), new Tuple<int, int>(2, 5)).Item2
                .SetCell(new CellStructure("-8.88178E-16"), new Tuple<int, int>(3, 5)).Item2
                .SetCell(new CellStructure("6.66134E-16"), new Tuple<int, int>(4, 5)).Item2
                .SetCell(new CellStructure("1.77636E-15"), new Tuple<int, int>(5, 5)).Item2
                .SetCell(new CellStructure("5.55112E-16"), new Tuple<int, int>(6, 5)).Item2
                .SetCell(new CellStructure("-1.4988E-15"), new Tuple<int, int>(7, 5)).Item2
                .SetCell(new CellStructure("5.68373E-14"), new Tuple<int, int>(0, 6)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(1, 6)).Item2
                .SetCell(new CellStructure("4.66294E-15"), new Tuple<int, int>(2, 6)).Item2
                .SetCell(new CellStructure("-1.9984E-15"), new Tuple<int, int>(3, 6)).Item2
                .SetCell(new CellStructure("1.11022E-16"), new Tuple<int, int>(4, 6)).Item2
                .SetCell(new CellStructure("2.22045E-16"), new Tuple<int, int>(5, 6)).Item2
                .SetCell(new CellStructure("7.21645E-16"), new Tuple<int, int>(6, 6)).Item2
                .SetCell(new CellStructure("6.10623E-16"), new Tuple<int, int>(7, 6)).Item2
                .SetCell(new CellStructure("-8.79252E-14"), new Tuple<int, int>(0, 7)).Item2
                .SetCell(new CellStructure("-2.22045E-16"), new Tuple<int, int>(1, 7)).Item2
                .SetCell(new CellStructure("7.77156E-16"), new Tuple<int, int>(2, 7)).Item2
                .SetCell(new CellStructure("9.99201E-16"), new Tuple<int, int>(3, 7)).Item2
                .SetCell(new CellStructure("-5.55112E-16"), new Tuple<int, int>(4, 7)).Item2
                .SetCell(new CellStructure("-1.11022E-15"), new Tuple<int, int>(5, 7)).Item2
                .SetCell(new CellStructure("1.83187E-15"), new Tuple<int, int>(6, 7)).Item2
                .SetCell(new CellStructure("-1.05471E-15"), new Tuple<int, int>(7, 7)).Item2
            );
            ValueCubeList.Add(new BlockStructure(8, 8)
                .SetCell(new CellStructure("-4.9738E-14"), new Tuple<int, int>(0, 0)).Item2
                .SetCell(new CellStructure("8.79252E-15"), new Tuple<int, int>(1, 0)).Item2
                .SetCell(new CellStructure("-6.90841E-15"), new Tuple<int, int>(2, 0)).Item2
                .SetCell(new CellStructure("-2.82617E-15"), new Tuple<int, int>(3, 0)).Item2
                .SetCell(new CellStructure("-5.0243E-15"), new Tuple<int, int>(4, 0)).Item2
                .SetCell(new CellStructure("2.35514E-15"), new Tuple<int, int>(5, 0)).Item2
                .SetCell(new CellStructure("-2.51215E-15"), new Tuple<int, int>(6, 0)).Item2
                .SetCell(new CellStructure("-1.57009E-16"), new Tuple<int, int>(7, 0)).Item2
                .SetCell(new CellStructure("-5.0243E-15"), new Tuple<int, int>(0, 1)).Item2
                .SetCell(new CellStructure("-3.55271E-15"), new Tuple<int, int>(1, 1)).Item2
                .SetCell(new CellStructure("-8.88178E-16"), new Tuple<int, int>(2, 1)).Item2
                .SetCell(new CellStructure("4.44089E-16"), new Tuple<int, int>(3, 1)).Item2
                .SetCell(new CellStructure("-8.88178E-16"), new Tuple<int, int>(4, 1)).Item2
                .SetCell(new CellStructure("-2.22045E-16"), new Tuple<int, int>(5, 1)).Item2
                .SetCell(new CellStructure("6.66134E-16"), new Tuple<int, int>(6, 1)).Item2
                .SetCell(new CellStructure("1.11022E-15"), new Tuple<int, int>(7, 1)).Item2
                .SetCell(new CellStructure("-1.7585E-14"), new Tuple<int, int>(0, 2)).Item2
                .SetCell(new CellStructure("-5.77316E-15"), new Tuple<int, int>(1, 2)).Item2
                .SetCell(new CellStructure("4.44089E-16"), new Tuple<int, int>(2, 2)).Item2
                .SetCell(new CellStructure("-2.66454E-15"), new Tuple<int, int>(3, 2)).Item2
                .SetCell(new CellStructure("2.22045E-16"), new Tuple<int, int>(4, 2)).Item2
                .SetCell(new CellStructure("-6.66134E-16"), new Tuple<int, int>(5, 2)).Item2
                .SetCell(new CellStructure("3.33067E-16"), new Tuple<int, int>(6, 2)).Item2
                .SetCell(new CellStructure("8.88178E-16"), new Tuple<int, int>(7, 2)).Item2
                .SetCell(new CellStructure("-5.65233E-15"), new Tuple<int, int>(0, 3)).Item2
                .SetCell(new CellStructure("3.55271E-15"), new Tuple<int, int>(1, 3)).Item2
                .SetCell(new CellStructure("-1.33227E-15"), new Tuple<int, int>(2, 3)).Item2
                .SetCell(new CellStructure("-4.44089E-16"), new Tuple<int, int>(3, 3)).Item2
                .SetCell(new CellStructure("-2.22045E-16"), new Tuple<int, int>(4, 3)).Item2
                .SetCell(new CellStructure("-4.44089E-16"), new Tuple<int, int>(5, 3)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(6, 3)).Item2
                .SetCell(new CellStructure("-2.22045E-16"), new Tuple<int, int>(7, 3)).Item2
                .SetCell(new CellStructure("-1.00486E-14"), new Tuple<int, int>(0, 4)).Item2
                .SetCell(new CellStructure("-2.22045E-15"), new Tuple<int, int>(1, 4)).Item2
                .SetCell(new CellStructure("1.9984E-15"), new Tuple<int, int>(2, 4)).Item2
                .SetCell(new CellStructure("2.22045E-16"), new Tuple<int, int>(3, 4)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(4, 4)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(5, 4)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(6, 4)).Item2
                .SetCell(new CellStructure("-2.22045E-16"), new Tuple<int, int>(7, 4)).Item2
                .SetCell(new CellStructure("3.14018E-16"), new Tuple<int, int>(0, 5)).Item2
                .SetCell(new CellStructure("-2.22045E-16"), new Tuple<int, int>(1, 5)).Item2
                .SetCell(new CellStructure("-8.88178E-16"), new Tuple<int, int>(2, 5)).Item2
                .SetCell(new CellStructure("-6.66134E-16"), new Tuple<int, int>(3, 5)).Item2
                .SetCell(new CellStructure("4.44089E-16"), new Tuple<int, int>(4, 5)).Item2
                .SetCell(new CellStructure("4.44089E-16"), new Tuple<int, int>(5, 5)).Item2
                .SetCell(new CellStructure("2.10942E-15"), new Tuple<int, int>(6, 5)).Item2
                .SetCell(new CellStructure("3.88578E-16"), new Tuple<int, int>(7, 5)).Item2
                .SetCell(new CellStructure("2.82617E-15"), new Tuple<int, int>(0, 6)).Item2
                .SetCell(new CellStructure("-3.55271E-15"), new Tuple<int, int>(1, 6)).Item2
                .SetCell(new CellStructure("1.77636E-15"), new Tuple<int, int>(2, 6)).Item2
                .SetCell(new CellStructure("1.22125E-15"), new Tuple<int, int>(3, 6)).Item2
                .SetCell(new CellStructure("2.22045E-16"), new Tuple<int, int>(4, 6)).Item2
                .SetCell(new CellStructure("7.77156E-16"), new Tuple<int, int>(5, 6)).Item2
                .SetCell(new CellStructure("1.88738E-15"), new Tuple<int, int>(6, 6)).Item2
                .SetCell(new CellStructure("1.05471E-15"), new Tuple<int, int>(7, 6)).Item2
                .SetCell(new CellStructure("2.51215E-15"), new Tuple<int, int>(0, 7)).Item2
                .SetCell(new CellStructure("1.9984E-15"), new Tuple<int, int>(1, 7)).Item2
                .SetCell(new CellStructure("2.10942E-15"), new Tuple<int, int>(2, 7)).Item2
                .SetCell(new CellStructure("-1.4988E-15"), new Tuple<int, int>(3, 7)).Item2
                .SetCell(new CellStructure("-9.99201E-16"), new Tuple<int, int>(4, 7)).Item2
                .SetCell(new CellStructure("5.55112E-17"), new Tuple<int, int>(5, 7)).Item2
                .SetCell(new CellStructure("1.11022E-15"), new Tuple<int, int>(6, 7)).Item2
                .SetCell(new CellStructure("2.77556E-16"), new Tuple<int, int>(7, 7)).Item2
            );
            ValueCubeList.Add(new BlockStructure(8, 8)
                .SetCell(new CellStructure("-114.747"), new Tuple<int, int>(0, 0)).Item2
                .SetCell(new CellStructure("-3.14018E-14"), new Tuple<int, int>(1, 0)).Item2
                .SetCell(new CellStructure("1.22467E-14"), new Tuple<int, int>(2, 0)).Item2
                .SetCell(new CellStructure("-8.16448E-15"), new Tuple<int, int>(3, 0)).Item2
                .SetCell(new CellStructure("-6.90841E-15"), new Tuple<int, int>(4, 0)).Item2
                .SetCell(new CellStructure("1.00486E-14"), new Tuple<int, int>(5, 0)).Item2
                .SetCell(new CellStructure("8.81607E-14"), new Tuple<int, int>(6, 0)).Item2
                .SetCell(new CellStructure("-1.39149E-13"), new Tuple<int, int>(7, 0)).Item2
                .SetCell(new CellStructure("-5.0243E-15"), new Tuple<int, int>(0, 1)).Item2
                .SetCell(new CellStructure("-4.44089E-15"), new Tuple<int, int>(1, 1)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(2, 1)).Item2
                .SetCell(new CellStructure("4.44089E-16"), new Tuple<int, int>(3, 1)).Item2
                .SetCell(new CellStructure("-4.44089E-16"), new Tuple<int, int>(4, 1)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(5, 1)).Item2
                .SetCell(new CellStructure("-1.22125E-15"), new Tuple<int, int>(6, 1)).Item2
                .SetCell(new CellStructure("-4.996E-16"), new Tuple<int, int>(7, 1)).Item2
                .SetCell(new CellStructure("-2.51215E-15"), new Tuple<int, int>(0, 2)).Item2
                .SetCell(new CellStructure("5.32907E-15"), new Tuple<int, int>(1, 2)).Item2
                .SetCell(new CellStructure("-8.88178E-16"), new Tuple<int, int>(2, 2)).Item2
                .SetCell(new CellStructure("-1.9984E-15"), new Tuple<int, int>(3, 2)).Item2
                .SetCell(new CellStructure("4.44089E-16"), new Tuple<int, int>(4, 2)).Item2
                .SetCell(new CellStructure("2.22045E-15"), new Tuple<int, int>(5, 2)).Item2
                .SetCell(new CellStructure("-5.55112E-16"), new Tuple<int, int>(6, 2)).Item2
                .SetCell(new CellStructure("-1.66533E-16"), new Tuple<int, int>(7, 2)).Item2
                .SetCell(new CellStructure("1.57009E-14"), new Tuple<int, int>(0, 3)).Item2
                .SetCell(new CellStructure("2.22045E-16"), new Tuple<int, int>(1, 3)).Item2
                .SetCell(new CellStructure("-4.44089E-16"), new Tuple<int, int>(2, 3)).Item2
                .SetCell(new CellStructure("1.77636E-15"), new Tuple<int, int>(3, 3)).Item2
                .SetCell(new CellStructure("-8.88178E-16"), new Tuple<int, int>(4, 3)).Item2
                .SetCell(new CellStructure("-8.88178E-16"), new Tuple<int, int>(5, 3)).Item2
                .SetCell(new CellStructure("1.11022E-16"), new Tuple<int, int>(6, 3)).Item2
                .SetCell(new CellStructure("-6.10623E-16"), new Tuple<int, int>(7, 3)).Item2
                .SetCell(new CellStructure("-3.76822E-15"), new Tuple<int, int>(0, 4)).Item2
                .SetCell(new CellStructure("1.77636E-15"), new Tuple<int, int>(1, 4)).Item2
                .SetCell(new CellStructure("-6.66134E-16"), new Tuple<int, int>(2, 4)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(3, 4)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(4, 4)).Item2
                .SetCell(new CellStructure("2.22045E-16"), new Tuple<int, int>(5, 4)).Item2
                .SetCell(new CellStructure("-1.66533E-15"), new Tuple<int, int>(6, 4)).Item2
                .SetCell(new CellStructure("4.996E-16"), new Tuple<int, int>(7, 4)).Item2
                .SetCell(new CellStructure("8.4785E-15"), new Tuple<int, int>(0, 5)).Item2
                .SetCell(new CellStructure("3.77476E-15"), new Tuple<int, int>(1, 5)).Item2
                .SetCell(new CellStructure("6.66134E-16"), new Tuple<int, int>(2, 5)).Item2
                .SetCell(new CellStructure("-1.33227E-15"), new Tuple<int, int>(3, 5)).Item2
                .SetCell(new CellStructure("-1.11022E-16"), new Tuple<int, int>(4, 5)).Item2
                .SetCell(new CellStructure("-8.88178E-16"), new Tuple<int, int>(5, 5)).Item2
                .SetCell(new CellStructure("-1.11022E-16"), new Tuple<int, int>(6, 5)).Item2
                .SetCell(new CellStructure("9.71445E-16"), new Tuple<int, int>(7, 5)).Item2
                .SetCell(new CellStructure("9.02803E-14"), new Tuple<int, int>(0, 6)).Item2
                .SetCell(new CellStructure("7.21645E-15"), new Tuple<int, int>(1, 6)).Item2
                .SetCell(new CellStructure("-6.66134E-16"), new Tuple<int, int>(2, 6)).Item2
                .SetCell(new CellStructure("-7.77156E-16"), new Tuple<int, int>(3, 6)).Item2
                .SetCell(new CellStructure("1.11022E-16"), new Tuple<int, int>(4, 6)).Item2
                .SetCell(new CellStructure("1.05471E-15"), new Tuple<int, int>(5, 6)).Item2
                .SetCell(new CellStructure("-1.94289E-15"), new Tuple<int, int>(6, 6)).Item2
                .SetCell(new CellStructure("-4.16334E-16"), new Tuple<int, int>(7, 6)).Item2
                .SetCell(new CellStructure("-1.42957E-13"), new Tuple<int, int>(0, 7)).Item2
                .SetCell(new CellStructure("2.72005E-15"), new Tuple<int, int>(1, 7)).Item2
                .SetCell(new CellStructure("6.10623E-16"), new Tuple<int, int>(2, 7)).Item2
                .SetCell(new CellStructure("-1.66533E-16"), new Tuple<int, int>(3, 7)).Item2
                .SetCell(new CellStructure("7.77156E-16"), new Tuple<int, int>(4, 7)).Item2
                .SetCell(new CellStructure("1.05471E-15"), new Tuple<int, int>(5, 7)).Item2
                .SetCell(new CellStructure("2.77556E-16"), new Tuple<int, int>(6, 7)).Item2
                .SetCell(new CellStructure("1.84575E-15"), new Tuple<int, int>(7, 7)).Item2
            );
            ValueCubeList.Add(new BlockStructure(8, 8)
                .SetCell(new CellStructure("-1.00209E-12"), new Tuple<int, int>(0, 0)).Item2
                .SetCell(new CellStructure("6.28037E-16"), new Tuple<int, int>(1, 0)).Item2
                .SetCell(new CellStructure("1.57009E-16"), new Tuple<int, int>(2, 0)).Item2
                .SetCell(new CellStructure("1.25607E-15"), new Tuple<int, int>(3, 0)).Item2
                .SetCell(new CellStructure("1.25607E-15"), new Tuple<int, int>(4, 0)).Item2
                .SetCell(new CellStructure("3.76822E-15"), new Tuple<int, int>(5, 0)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(6, 0)).Item2
                .SetCell(new CellStructure("-3.76822E-15"), new Tuple<int, int>(7, 0)).Item2
                .SetCell(new CellStructure("1.41308E-14"), new Tuple<int, int>(0, 1)).Item2
                .SetCell(new CellStructure("-3.77476E-15"), new Tuple<int, int>(1, 1)).Item2
                .SetCell(new CellStructure("-2.44249E-15"), new Tuple<int, int>(2, 1)).Item2
                .SetCell(new CellStructure("0"), new Tuple<int, int>(3, 1)).Item2
                .SetCell(new CellStructure("4.44089E-16"), new Tuple<int, int>(4, 1)).Item2
                .SetCell(new CellStructure("-7.77156E-16"), new Tuple<int, int>(5, 1)).Item2
                .SetCell(new CellStructure("-6.66134E-16"), new Tuple<int, int>(6, 1)).Item2
                .SetCell(new CellStructure("9.4369E-16"), new Tuple<int, int>(7, 1)).Item2
                .SetCell(new CellStructure("6.59439E-15"), new Tuple<int, int>(0, 2)).Item2
                .SetCell(new CellStructure("6.66134E-16"), new Tuple<int, int>(1, 2)).Item2
                .SetCell(new CellStructure("-1.11022E-15"), new Tuple<int, int>(2, 2)).Item2
                .SetCell(new CellStructure("-1.33227E-15"), new Tuple<int, int>(3, 2)).Item2
                .SetCell(new CellStructure("4.44089E-16"), new Tuple<int, int>(4, 2)).Item2
                .SetCell(new CellStructure("-1.44329E-15"), new Tuple<int, int>(5, 2)).Item2
                .SetCell(new CellStructure("-5.55112E-16"), new Tuple<int, int>(6, 2)).Item2
                .SetCell(new CellStructure("-8.88178E-16"), new Tuple<int, int>(7, 2)).Item2
                .SetCell(new CellStructure("9.10654E-15"), new Tuple<int, int>(0, 3)).Item2
                .SetCell(new CellStructure("-6.21725E-15"), new Tuple<int, int>(1, 3)).Item2
                .SetCell(new CellStructure("6.66134E-16"), new Tuple<int, int>(2, 3)).Item2
                .SetCell(new CellStructure("-2.22045E-16"), new Tuple<int, int>(3, 3)).Item2
                .SetCell(new CellStructure("4.44089E-16"), new Tuple<int, int>(4, 3)).Item2
                .SetCell(new CellStructure("3.33067E-16"), new Tuple<int, int>(5, 3)).Item2
                .SetCell(new CellStructure("-1.11022E-16"), new Tuple<int, int>(6, 3)).Item2
                .SetCell(new CellStructure("-4.996E-16"), new Tuple<int, int>(7, 3)).Item2
                .SetCell(new CellStructure("3.14018E-16"), new Tuple<int, int>(0, 4)).Item2
                .SetCell(new CellStructure("2.22045E-15"), new Tuple<int, int>(1, 4)).Item2
                .SetCell(new CellStructure("4.44089E-16"), new Tuple<int, int>(2, 4)).Item2
                .SetCell(new CellStructure("-6.66134E-16"), new Tuple<int, int>(3, 4)).Item2
                .SetCell(new CellStructure("3.33067E-16"), new Tuple<int, int>(4, 4)).Item2
                .SetCell(new CellStructure("-7.77156E-16"), new Tuple<int, int>(5, 4)).Item2
                .SetCell(new CellStructure("3.88578E-16"), new Tuple<int, int>(6, 4)).Item2
                .SetCell(new CellStructure("1.02696E-15"), new Tuple<int, int>(7, 4)).Item2
                .SetCell(new CellStructure("1.25607E-15"), new Tuple<int, int>(0, 5)).Item2
                .SetCell(new CellStructure("3.10862E-15"), new Tuple<int, int>(1, 5)).Item2
                .SetCell(new CellStructure("5.55112E-16"), new Tuple<int, int>(2, 5)).Item2
                .SetCell(new CellStructure("-4.44089E-16"), new Tuple<int, int>(3, 5)).Item2
                .SetCell(new CellStructure("-5.55112E-16"), new Tuple<int, int>(4, 5)).Item2
                .SetCell(new CellStructure("-1.27676E-15"), new Tuple<int, int>(5, 5)).Item2
                .SetCell(new CellStructure("9.99201E-16"), new Tuple<int, int>(6, 5)).Item2
                .SetCell(new CellStructure("-1.08247E-15"), new Tuple<int, int>(7, 5)).Item2
                .SetCell(new CellStructure("2.35514E-15"), new Tuple<int, int>(0, 6)).Item2
                .SetCell(new CellStructure("2.77556E-15"), new Tuple<int, int>(1, 6)).Item2
                .SetCell(new CellStructure("-1.22125E-15"), new Tuple<int, int>(2, 6)).Item2
                .SetCell(new CellStructure("2.22045E-16"), new Tuple<int, int>(3, 6)).Item2
                .SetCell(new CellStructure("1.38778E-15"), new Tuple<int, int>(4, 6)).Item2
                .SetCell(new CellStructure("6.10623E-16"), new Tuple<int, int>(5, 6)).Item2
                .SetCell(new CellStructure("1.22125E-15"), new Tuple<int, int>(6, 6)).Item2
                .SetCell(new CellStructure("-1.95677E-15"), new Tuple<int, int>(7, 6)).Item2
                .SetCell(new CellStructure("-1.31888E-14"), new Tuple<int, int>(0, 7)).Item2
                .SetCell(new CellStructure("2.9976E-15"), new Tuple<int, int>(1, 7)).Item2
                .SetCell(new CellStructure("1.27676E-15"), new Tuple<int, int>(2, 7)).Item2
                .SetCell(new CellStructure("-3.05311E-16"), new Tuple<int, int>(3, 7)).Item2
                .SetCell(new CellStructure("1.08247E-15"), new Tuple<int, int>(4, 7)).Item2
                .SetCell(new CellStructure("-5.82867E-16"), new Tuple<int, int>(5, 7)).Item2
                .SetCell(new CellStructure("-1.26288E-15"), new Tuple<int, int>(6, 7)).Item2
                .SetCell(new CellStructure("5.34295E-16"), new Tuple<int, int>(7, 7)).Item2
            );
            ValueCubeList.Add(new BlockStructure(8, 8)
                .SetCell(new CellStructure("-326.772"), new Tuple<int, int>(0, 0)).Item2
                .SetCell(new CellStructure("-3.41495E-14"), new Tuple<int, int>(1, 0)).Item2
                .SetCell(new CellStructure("3.26579E-14"), new Tuple<int, int>(2, 0)).Item2
                .SetCell(new CellStructure("-3.51701E-14"), new Tuple<int, int>(3, 0)).Item2
                .SetCell(new CellStructure("-1.31888E-14"), new Tuple<int, int>(4, 0)).Item2
                .SetCell(new CellStructure("2.51215E-14"), new Tuple<int, int>(5, 0)).Item2
                .SetCell(new CellStructure("2.49174E-13"), new Tuple<int, int>(6, 0)).Item2
                .SetCell(new CellStructure("-3.90796E-13"), new Tuple<int, int>(7, 0)).Item2
                .SetCell(new CellStructure("-3.18729E-14"), new Tuple<int, int>(0, 1)).Item2
                .SetCell(new CellStructure("-2.66454E-15"), new Tuple<int, int>(1, 1)).Item2
                .SetCell(new CellStructure("-3.21965E-15"), new Tuple<int, int>(2, 1)).Item2
                .SetCell(new CellStructure("-7.77156E-16"), new Tuple<int, int>(3, 1)).Item2
                .SetCell(new CellStructure("-8.88178E-16"), new Tuple<int, int>(4, 1)).Item2
                .SetCell(new CellStructure("8.32667E-16"), new Tuple<int, int>(5, 1)).Item2
                .SetCell(new CellStructure("-1.27676E-15"), new Tuple<int, int>(6, 1)).Item2
                .SetCell(new CellStructure("-1.08247E-15"), new Tuple<int, int>(7, 1)).Item2
                .SetCell(new CellStructure("5.85644E-14"), new Tuple<int, int>(0, 2)).Item2
                .SetCell(new CellStructure("1.66533E-15"), new Tuple<int, int>(1, 2)).Item2
                .SetCell(new CellStructure("-2.22045E-15"), new Tuple<int, int>(2, 2)).Item2
                .SetCell(new CellStructure("-7.77156E-16"), new Tuple<int, int>(3, 2)).Item2
                .SetCell(new CellStructure("1.88738E-15"), new Tuple<int, int>(4, 2)).Item2
                .SetCell(new CellStructure("7.77156E-16"), new Tuple<int, int>(5, 2)).Item2
                .SetCell(new CellStructure("-1.33227E-15"), new Tuple<int, int>(6, 2)).Item2
                .SetCell(new CellStructure("-1.58207E-15"), new Tuple<int, int>(7, 2)).Item2
                .SetCell(new CellStructure("-2.32374E-14"), new Tuple<int, int>(0, 3)).Item2
                .SetCell(new CellStructure("3.33067E-15"), new Tuple<int, int>(1, 3)).Item2
                .SetCell(new CellStructure("7.77156E-16"), new Tuple<int, int>(2, 3)).Item2
                .SetCell(new CellStructure("-3.33067E-16"), new Tuple<int, int>(3, 3)).Item2
                .SetCell(new CellStructure("-1.66533E-15"), new Tuple<int, int>(4, 3)).Item2
                .SetCell(new CellStructure("-2.55351E-15"), new Tuple<int, int>(5, 3)).Item2
                .SetCell(new CellStructure("-1.94289E-15"), new Tuple<int, int>(6, 3)).Item2
                .SetCell(new CellStructure("2.498E-16"), new Tuple<int, int>(7, 3)).Item2
                .SetCell(new CellStructure("-8.16448E-15"), new Tuple<int, int>(0, 4)).Item2
                .SetCell(new CellStructure("3.10862E-15"), new Tuple<int, int>(1, 4)).Item2
                .SetCell(new CellStructure("5.55112E-16"), new Tuple<int, int>(2, 4)).Item2
                .SetCell(new CellStructure("1.27676E-15"), new Tuple<int, int>(3, 4)).Item2
                .SetCell(new CellStructure("1.94289E-15"), new Tuple<int, int>(4, 4)).Item2
                .SetCell(new CellStructure("7.21645E-16"), new Tuple<int, int>(5, 4)).Item2
                .SetCell(new CellStructure("5.55112E-16"), new Tuple<int, int>(6, 4)).Item2
                .SetCell(new CellStructure("1.95677E-15"), new Tuple<int, int>(7, 4)).Item2
                .SetCell(new CellStructure("2.69271E-14"), new Tuple<int, int>(0, 5)).Item2
                .SetCell(new CellStructure("1.38778E-15"), new Tuple<int, int>(1, 5)).Item2
                .SetCell(new CellStructure("-4.60743E-15"), new Tuple<int, int>(2, 5)).Item2
                .SetCell(new CellStructure("-1.9984E-15"), new Tuple<int, int>(3, 5)).Item2
                .SetCell(new CellStructure("7.21645E-16"), new Tuple<int, int>(4, 5)).Item2
                .SetCell(new CellStructure("3.02536E-15"), new Tuple<int, int>(5, 5)).Item2
                .SetCell(new CellStructure("-2.35922E-15"), new Tuple<int, int>(6, 5)).Item2
                .SetCell(new CellStructure("9.15934E-16"), new Tuple<int, int>(7, 5)).Item2
                .SetCell(new CellStructure("2.57495E-13"), new Tuple<int, int>(0, 6)).Item2
                .SetCell(new CellStructure("5.93969E-15"), new Tuple<int, int>(1, 6)).Item2
                .SetCell(new CellStructure("-2.94209E-15"), new Tuple<int, int>(2, 6)).Item2
                .SetCell(new CellStructure("1.7486E-15"), new Tuple<int, int>(3, 6)).Item2
                .SetCell(new CellStructure("-8.32667E-17"), new Tuple<int, int>(4, 6)).Item2
                .SetCell(new CellStructure("-8.32667E-16"), new Tuple<int, int>(5, 6)).Item2
                .SetCell(new CellStructure("-9.15934E-16"), new Tuple<int, int>(6, 6)).Item2
                .SetCell(new CellStructure("1.08941E-15"), new Tuple<int, int>(7, 6)).Item2
                .SetCell(new CellStructure("-3.88284E-13"), new Tuple<int, int>(0, 7)).Item2
                .SetCell(new CellStructure("-1.33227E-15"), new Tuple<int, int>(1, 7)).Item2
                .SetCell(new CellStructure("-1.9984E-15"), new Tuple<int, int>(2, 7)).Item2
                .SetCell(new CellStructure("1.05471E-15"), new Tuple<int, int>(3, 7)).Item2
                .SetCell(new CellStructure("9.29812E-16"), new Tuple<int, int>(4, 7)).Item2
                .SetCell(new CellStructure("7.21645E-16"), new Tuple<int, int>(5, 7)).Item2
                .SetCell(new CellStructure("5.34295E-16"), new Tuple<int, int>(6, 7)).Item2
                .SetCell(new CellStructure("3.66027E-15"), new Tuple<int, int>(7, 7)).Item2
            );

            ReturnObject.Add(new KeyValuePair<BlockStructures, BlockStructures>(
                new BlockStructures(KeyCubeList), new BlockStructures(ValueCubeList)
                ));

            return ReturnObject;
        }

        public BlockStructures Add(BlockStructure NewBlockStructure)
        {
            this.BlockStructureList.Add(NewBlockStructure);
            return this;
        }

        public BlockStructures Add(List<BlockStructure> NewBlockStructureList)
        {
            this.BlockStructureList.AddRange(NewBlockStructureList);
            return this;
        }

        public BlockStructures Add(BlockStructures NewBlockStructures)
        {
            this.BlockStructureList.AddRange(NewBlockStructures.GetList());
            return this;
        }

        public BlockStructures DeepClone()
        {
            return (BlockStructures)DeepClone(this);
        }

        public List<BlockStructure> GetList()
        {
            return this.BlockStructureList;
        }

        public BlockStructures RemoveAt(int Index)
        {
            this.BlockStructureList.RemoveAt(Index);
            return this;
        }

        public int Size()
        {
            return this.BlockStructureList.Count;
        }

        public override bool Equals(object obj)
        {
            BlockStructures InputBlockStructures = obj as BlockStructures;
            if (InputBlockStructures.Size().Equals(this.Size()).Equals(false))
            {
                return false;
            }
            foreach (var EachBlockStructure in this.BlockStructureList.Select((Value, Index) => new { Index, Value }))
            {
                if (EachBlockStructure.Value.Equals(InputBlockStructures.GetList()[EachBlockStructure.Index]).Equals(false))
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder OutputString = new StringBuilder();
            foreach (var EachBlockStructure in this.BlockStructureList.Select((Value, Index) => new { Index, Value }))
            {
                OutputString.Append("BlockStructure" + EachBlockStructure.Index.ToString() + ":" + System.Environment.NewLine);
                OutputString.Append(EachBlockStructure.Value.ToString());
            }
            return OutputString.ToString();
        }

        public BlockStructure this[int Index]
        {
            //    The get accessor
            get
            {
                if (Index >= 0 && Index <= this.BlockStructureList.Count - 1)
                {
                    return this.BlockStructureList[Index];
                }
                else
                {
                    return null;
                }

            }

            //    The set accessor
            set
            {
                if (Index >= 0 && Index <= this.BlockStructureList.Count - 1)
                {
                    this.BlockStructureList[Index] = value;
                }
            }
        }
    }
}

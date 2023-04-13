using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex2API.Data
{
    public class BurialData
    {
        public float headdirection_ { get; set; }
        public float headdirection_E { get; set; }
        public float headdirection_W { get; set; }
        public float ageatdeath_ { get; set; }
        public float ageatdeath_A { get; set; }
        public float ageatdeath_C { get; set; }
        public float ageatdeath_I { get; set; }
        public float ageatdeath_N { get; set; }
        public float material_Linen { get; set; }
        public float material_Linen_background { get; set; }
        public float material_Linen_red { get; set; }
        public float material_Linen_VLS { get; set; }
        public float material_Other { get; set; }
        public float material_Other_burlap { get; set; }
        public float material_Other_vegetable_fiber { get; set; }
        public float material_Wool { get; set; }
        public float material_Wool_tapestry { get; set; }
        public float material_Wool_thread { get; set; }
      
        public Tensor<float> AsTensor()
        {
            float[] data = new float[]
            {
              headdirection_, headdirection_E, headdirection_W, ageatdeath_,
              ageatdeath_A, ageatdeath_C, ageatdeath_I, ageatdeath_N,
               material_Linen, material_Linen_background, material_Linen_red, material_Linen_VLS,
               material_Other, material_Other_burlap, material_Other_vegetable_fiber, material_Wool,
               material_Wool_tapestry, material_Wool_thread
            };
            int[] dimensions = new int[] { 1, 18 };
            return new DenseTensor<float>(data, dimensions);
        }
    }
}
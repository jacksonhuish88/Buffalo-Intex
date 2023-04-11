using Microsoft.AspNetCore.Builder;

namespace Buffalo_Intex.Controllers
{
    internal class InferenceSession
    {
        private string modelPath;
        private SessionOptions sessionOptions;

        public InferenceSession(string modelPath, SessionOptions sessionOptions)
        {
            this.modelPath = modelPath;
            this.sessionOptions = sessionOptions;
        }
    }
}
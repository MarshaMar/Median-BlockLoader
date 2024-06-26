﻿using BlockLoader.Utils;

namespace BlockLoader.PresentationLayer
{
	public class BlockViewModel : NotifyPropertyChangedBase
	{
		public BlockViewModel(string code, int footage, string program)
		{
			Code = code;
			Footage = footage;
			Program = program;
            ViewerCount = 0;
        }

		public string Code { get; }
		public int Footage { get; }
		public string Program { get; }
        public int ViewerCount { get; set; }
    }
}
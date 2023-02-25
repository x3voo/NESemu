﻿using System;
using System.Collections.Generic;
using System.Text;

namespace emulatorTest.PPU2C02.Flags
{
    public class PPUControlFlags
    {

		public Byte reg = 0x00;

		public Byte nametable_x
		{
			get
			{
				return (Byte)((reg >> 0) & (Byte)1);
			}
			set
			{
				reg = (Byte)(reg & ~((Byte)0b1 << 0));
				reg = (Byte)(reg | ((value & (Byte)0b1) << 0));
			}
		}

		public Byte nametable_y
		{
			get
			{
				return (Byte)((reg >> 1) & (Byte)1);
			}
			set
			{
				reg = (Byte)(reg & ~((Byte)0b1 << 1));
				reg = (Byte)(reg | ((value & (Byte)0b1) << 1));
			}
		}

		public Byte increment_mode
		{
			get
			{
				return (Byte)((reg >> 2) & (Byte)1);
			}
			set
			{
				reg = (Byte)(reg & ~((Byte)0b1 << 2));
				reg = (Byte)(reg | ((value & (Byte)0b1) << 2));
			}
		}

		public Byte pattern_sprite
		{
			get
			{
				return (Byte)((reg >> 3) & (Byte)1);
			}
			set
			{
				reg = (Byte)(reg & ~((Byte)0b1 << 3));
				reg = (Byte)(reg | ((value & (Byte)0b1) << 3));
			}
		}

		public Byte pattern_background
		{
			get
			{
				return (Byte)((reg >> 4) & (Byte)1);
			}
			set
			{
				reg = (Byte)(reg & ~((Byte)0b1 << 4));
				reg = (Byte)(reg | ((value & (Byte)0b1) << 4));
			}
		}

		public Byte sprite_size
		{
			get
			{
				return (Byte)((reg >> 5) & (Byte)1);
			}
			set
			{
				reg = (Byte)(reg & ~((Byte)0b1 << 5));
				reg = (Byte)(reg | ((value & (Byte)0b1) << 5));
			}
		}

		public Byte slave_mode
		{
			get
			{
				return (Byte)((reg >> 6) & (Byte)1);
			}
			set
			{
				reg = (Byte)(reg & ~((Byte)0b1 << 6));
				reg = (Byte)(reg | ((value & (Byte)0b1) << 6));
			}
		}

		public Byte enable_nmi
		{
			get
			{
				return (Byte)((reg >> 7) & (Byte)1);
			}
			set
			{
				reg = (Byte)(reg & ~((Byte)0b1 << 7));
				reg = (Byte)(reg | ((value & (Byte)0b1) << 7));
			}
		}
	}
}
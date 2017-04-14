﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes.Nodes
{
	class StartStatistic : INode
	{
		private string nameOfStatistic;
		public override string Description
		{
			get
			{
				description = String.Format("QUEUE {0}", nameOfStatistic);
				return description;
			}
		}

		public string NameOfStatistic
		{
			get
			{
				return nameOfStatistic;
			}

			set
			{
				nameOfStatistic = value;
			}
		}

		public StartStatistic()
		{
			this.id = "unknown StartStatistic node";
		}

		public StartStatistic(string id)
		{
			this.id = id;
			label = string.Format("Label_{0}", id);
		}
	}
}
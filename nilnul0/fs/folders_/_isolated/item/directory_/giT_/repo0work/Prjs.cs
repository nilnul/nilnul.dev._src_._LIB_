﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._isolated.item.directory_.giT_.repo0work
{
	public class Prjs
	{
		nilnul.fs.folders_.isolated._prjs.Io io;

		public Prjs(nilnul.fs.folders_.isolated._prjs.Io io)
		{
			this.io = io;
		}

		public IEnumerable<string> seq_ofAddress(
			string folder
		) {
			if (nilnul.fs.folder.be_.link_._ThisSymX.Be_ofAddress(folder))
			{
				return new directory_.link_.giT_.repo0work.Prjs(io).seq_ofAddress(folder);

			}
			else
			{
				return new directory_.unjoint_.giT_.repo0work.Prjs(io).seq_ofAddress(folder);
			}

			

		}
	}
}

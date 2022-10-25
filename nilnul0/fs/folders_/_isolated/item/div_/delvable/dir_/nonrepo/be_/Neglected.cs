using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._isolated.item.div_.delvable.dir_.nonrepo.be_
{
	public class Neglected : nilnul.fs.folder.BeI
	{
		public bool _be_assumeNotDotLed(FolderI obj)
		{
			if (nilnul.fs.folder.be_.link_._ThisSymX.Be(obj) )
			{
				return true;
			}
			return false;
		}

		public bool be(folder_.ParentDir obj)
		{
			return obj.en.child.denote.en.StartsWith(".") || _be_assumeNotDotLed(obj);

				;
		}


		public bool be(FolderI obj)
		{
			return be(folder_.ParentDir.Of(obj));
		}
		public bool be_ofAddress(string obj)
		{
			return be(
				Folder.FroAddress(obj)
			);
		}

		public bool be(nilnul.fs.address_.ShieldI obj)
		{
			return be(new Folder(obj));
		}

		static public Neglected Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Neglected>.Instance;
			}
		}

	}
}

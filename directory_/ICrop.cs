using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.directory_
{
	/// <summary>
	/// a work output, can be published to a remote repo. excluding .git, or any dotLed, dir in any seg of the path, as those are regarded as settings used locally, unpublished.
	/// </summary>
	/// <see cref="src.div_.IWordsable"/>
	/// <see cref="src.sln.div_.ICrop"/>
	/// alias:
	///		crop
	///			some div, such as ".foo", is not crop in that they are settings, not output. those are clipped out in traversing.
	///		creative
	///		nonchore
	///			which is nontrivia
	///		artifact
	///		nonbot
	///		transferable
	///		effect
	///		effort
	///		achieve
	///		cull
	///		pluck
	///		fruit
	///		vail
	///		ply
	///		yield
	///		reward
	///		pay out
	///		gain
	///		harvest
	///		output
	///		reap
	///		result
	///		resource
	///		deed
	///		depot
	///			maybe taken by <see cref="nilnul.fs.GitI"/>
	///		raw
	///			taken by <see cref="nilnul.dev.ISrc"/>
	///		svc
	///		toil
	///		slog
	///		fag
	///		site
	///		mill
	///		peg
	///		plod
	///		trek
	///		effort
	///		post
	///		job
	///		endeaver
	///		
	public interface ICrop:wordsable_.IDwelt
	{
	}
}


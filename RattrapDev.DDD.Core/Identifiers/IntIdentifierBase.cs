﻿namespace RattrapDev.DDD.Core.Identifier
{
	/// <summary>
	/// Base int <see cref="IdentifierBase{int}"/> implementation. 
	/// </summary>
	public class IntIdentifierBase : IdentifierBase<int>
	{
		public IntIdentifierBase(int id)
			: base(id)
		{
		}
	}
}


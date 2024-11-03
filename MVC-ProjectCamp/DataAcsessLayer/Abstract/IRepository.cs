using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.Abstract
{
	public interface IRepository<T>
	{
		List<T> List();
		void Add(T item);
		void Update(T item);
		void Delete(T item);
		
	}
}

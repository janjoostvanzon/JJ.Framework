using Iesi.Collections.Generic;

namespace NHibernate.Test.NHSpecificTest.NH1027
{
	public class Item
	{
		private int id;
		private string name;
		private ISet<Container> containers = new HashedSet<Container>();
		private ISet<Ship> ships = new HashedSet<Ship>();

		public virtual int Id
		{
			get { return id; }
			set { id = value; }
		}

		public virtual string Name
		{
			get { return name; }
			set { name = value; }
		}

		public virtual string Name1
		{
			get { return name; }
			set { name = value; }
		}

		public virtual string Name2
		{
			get { return name; }
			set { name = value; }
		}

		public virtual string Name3
		{
			get { return name; }
			set { name = value; }
		}

		public virtual string Name4
		{
			get { return name; }
			set { name = value; }
		}

		public virtual string Name5
		{
			get { return name; }
			set { name = value; }
		}

		public virtual string Name6
		{
			get { return name; }
			set { name = value; }
		}

		public virtual string Name7
		{
			get { return name; }
			set { name = value; }
		}


		public virtual ISet<Container> Containers
		{
			get { return containers; }
			set { containers = value; }
		}

		public virtual ISet<Ship> Ships
		{
			get { return ships; }
			set { ships = value; }
		}
	}

	public class Container
	{
		private int id;
		private string name;

		public virtual string Name
		{
			get { return name; }
			set { name = value; }
		}

		public virtual int Id
		{
			get { return id; }
			set { id = value; }
		}
	}

	public class Ship
	{
		private int id;
		private string name;

		public virtual string Name
		{
			get { return name; }
			set { name = value; }
		}

		public virtual int Id
		{
			get { return id; }
			set { id = value; }
		}

	}
}
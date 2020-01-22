﻿using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

[CollectionDataContract(Namespace = "")]
public class GClass4<Mtu0HAjOQdBt0morPt> : ICollection<Mtu0HAjOQdBt0morPt>, IEnumerable<Mtu0HAjOQdBt0morPt>, IReadOnlyList<Mtu0HAjOQdBt0morPt>, IReadOnlyCollection<Mtu0HAjOQdBt0morPt>, IEnumerable, ICollection
{
	[CompilerGenerated]
	public void method_0(GDelegate0 gdelegate0_1)
	{
		GDelegate0 gdelegate = this.gdelegate0_0;
		GDelegate0 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GDelegate0 value = (GDelegate0)Delegate.Combine(gdelegate2, gdelegate0_1);
			gdelegate = Interlocked.CompareExchange<GDelegate0>(ref this.gdelegate0_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	[CompilerGenerated]
	public void method_1(GDelegate0 gdelegate0_1)
	{
		GDelegate0 gdelegate = this.gdelegate0_0;
		GDelegate0 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GDelegate0 value = (GDelegate0)Delegate.Remove(gdelegate2, gdelegate0_1);
			gdelegate = Interlocked.CompareExchange<GDelegate0>(ref this.gdelegate0_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	[CompilerGenerated]
	public Dispatcher method_2()
	{
		return this.dispatcher_0;
	}

	[CompilerGenerated]
	public void method_3(Dispatcher dispatcher_1)
	{
		this.dispatcher_0 = dispatcher_1;
	}

	public ObservableCollection<Mtu0HAjOQdBt0morPt> ObsColl
	{
		get
		{
			return this.observableCollection_0;
		}
	}

	public GClass4()
	{
		Class13.plZSWFPzBWWEZ();
		this.list_0 = new List<Mtu0HAjOQdBt0morPt>();
		this.list_1 = new List<Mtu0HAjOQdBt0morPt>();
		this.object_0 = new object();
		this.list_2 = new List<Mtu0HAjOQdBt0morPt>();
		this.observableCollection_0 = new ObservableCollection<Mtu0HAjOQdBt0morPt>();
		this.concurrentQueue_0 = new ConcurrentQueue<NotifyCollectionChangedEventArgs>();
		base..ctor();
		this.method_3(Application.Current.Dispatcher);
	}

	public bool method_4()
	{
		return this.bool_0;
	}

	public void method_5(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	public Tuple<List<Mtu0HAjOQdBt0morPt>, List<Mtu0HAjOQdBt0morPt>> method_6()
	{
		object obj = this.object_0;
		Tuple<List<Mtu0HAjOQdBt0morPt>, List<Mtu0HAjOQdBt0morPt>> result;
		lock (obj)
		{
			result = new Tuple<List<Mtu0HAjOQdBt0morPt>, List<Mtu0HAjOQdBt0morPt>>(this.list_0, this.list_1);
			this.list_0 = new List<Mtu0HAjOQdBt0morPt>();
			this.list_1 = new List<Mtu0HAjOQdBt0morPt>();
		}
		return result;
	}

	public Mtu0HAjOQdBt0morPt[] method_7()
	{
		object obj = this.object_0;
		Mtu0HAjOQdBt0morPt[] result;
		lock (obj)
		{
			result = this.list_0.ToArray();
		}
		return result;
	}

	public Mtu0HAjOQdBt0morPt[] method_8()
	{
		object obj = this.object_0;
		Mtu0HAjOQdBt0morPt[] result;
		lock (obj)
		{
			result = this.list_1.ToArray();
		}
		return result;
	}

	private void method_9(NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_0)
	{
		this.concurrentQueue_0.Enqueue(notifyCollectionChangedEventArgs_0);
		this.method_2().BeginInvoke(new Action(this.method_10), Array.Empty<object>());
	}

	private void method_10()
	{
		if (!this.method_2().CheckAccess())
		{
			throw new Exception("Can't be called from any thread than the dispatcher one");
		}
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs;
		while (this.concurrentQueue_0.TryDequeue(out notifyCollectionChangedEventArgs))
		{
			switch (notifyCollectionChangedEventArgs.Action)
			{
			case NotifyCollectionChangedAction.Add:
			{
				int num = 0;
				using (IEnumerator enumerator = notifyCollectionChangedEventArgs.NewItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						Mtu0HAjOQdBt0morPt item = (Mtu0HAjOQdBt0morPt)((object)obj);
						this.ObsColl.Insert(notifyCollectionChangedEventArgs.NewStartingIndex + num, item);
						num++;
					}
					continue;
				}
				break;
			}
			case NotifyCollectionChangedAction.Remove:
				break;
			case NotifyCollectionChangedAction.Replace:
				goto IL_10B;
			case NotifyCollectionChangedAction.Move:
				this.ObsColl.Move(notifyCollectionChangedEventArgs.OldStartingIndex, notifyCollectionChangedEventArgs.NewStartingIndex);
				continue;
			case NotifyCollectionChangedAction.Reset:
				this.ObsColl.Clear();
				continue;
			default:
				throw new Exception("Unsupported NotifyCollectionChangedEventArgs.Action");
			}
			if (notifyCollectionChangedEventArgs.NewStartingIndex >= 0)
			{
				this.ObsColl.RemoveAt(notifyCollectionChangedEventArgs.NewStartingIndex);
				continue;
			}
			using (IEnumerator enumerator = notifyCollectionChangedEventArgs.OldItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj2 = enumerator.Current;
					Mtu0HAjOQdBt0morPt item2 = (Mtu0HAjOQdBt0morPt)((object)obj2);
					this.ObsColl.Remove(item2);
				}
				continue;
			}
			IL_10B:
			if (notifyCollectionChangedEventArgs.NewStartingIndex >= 0 && notifyCollectionChangedEventArgs.OldStartingIndex < 0)
			{
				throw new ArgumentException(string.Format("Replace action expect NewStartingIndex and OldStartingIndex as: 0 <= {0} <= {1}, {2} <= 0.", notifyCollectionChangedEventArgs.NewStartingIndex, this.ObsColl.Count, notifyCollectionChangedEventArgs.OldStartingIndex));
			}
			bool oldItems = notifyCollectionChangedEventArgs.OldItems != null;
			IList newItems = notifyCollectionChangedEventArgs.NewItems;
			if (!oldItems || newItems == null)
			{
				throw new ArgumentException("Both argument Old and New item should be IList in a replace action.");
			}
			this.ObsColl[notifyCollectionChangedEventArgs.NewStartingIndex] = (Mtu0HAjOQdBt0morPt)((object)newItems[0]);
		}
	}

	public List<Mtu0HAjOQdBt0morPt> method_11()
	{
		List<Mtu0HAjOQdBt0morPt> result = null;
		object obj = this.object_0;
		lock (obj)
		{
			result = new List<Mtu0HAjOQdBt0morPt>(this.list_2);
		}
		return result;
	}

	public void method_12(IList ilist_0)
	{
		GClass4<Mtu0HAjOQdBt0morPt>.<>c__DisplayClass26_0 CS$<>8__locals1 = new GClass4<Mtu0HAjOQdBt0morPt>.<>c__DisplayClass26_0();
		CS$<>8__locals1.list = ilist_0;
		object obj = this.object_0;
		lock (obj)
		{
			this.list_2.smethod_4(new Action<Mtu0HAjOQdBt0morPt>(CS$<>8__locals1.method_0));
		}
	}

	public virtual IEnumerator<Mtu0HAjOQdBt0morPt> GetEnumerator()
	{
		return this.method_11().GetEnumerator();
	}

	public virtual IEnumerator<Mtu0HAjOQdBt0morPt> GetBlockingEnumerator()
	{
		return new GClass1<Mtu0HAjOQdBt0morPt>(this.list_2.GetEnumerator(), this.object_0);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.method_11().GetEnumerator();
	}

	public void method_13(Mtu0HAjOQdBt0morPt QCI8gC8IZhAvFkPRwE)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_2.Insert(0, QCI8gC8IZhAvFkPRwE);
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, QCI8gC8IZhAvFkPRwE, 0);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public void Add(Mtu0HAjOQdBt0morPt BHWZ7xvUTcsTvmwT28)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_2.Add(BHWZ7xvUTcsTvmwT28);
			if (this.bool_0)
			{
				this.list_0.Add(BHWZ7xvUTcsTvmwT28);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, BHWZ7xvUTcsTvmwT28, this.list_2.Count - 1);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public void aTgkkDeOj(IList<Mtu0HAjOQdBt0morPt> ilist_0)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			int count = this.list_2.Count;
			this.list_2.AddRange(ilist_0);
			if (this.bool_0)
			{
				this.list_0.AddRange(ilist_0);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, ilist_0 as IList, count);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public bool method_14(Mtu0HAjOQdBt0morPt HnbRjDKpNuLBVWhw7h)
	{
		bool result = false;
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			result = this.list_2.Remove(HnbRjDKpNuLBVWhw7h);
			if (this.bool_0)
			{
				this.list_0.Add(HnbRjDKpNuLBVWhw7h);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, HnbRjDKpNuLBVWhw7h);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
		return result;
	}

	public void method_15(Mtu0HAjOQdBt0morPt TGrXAM5jIHs0YeBYYK, Mtu0HAjOQdBt0morPt mw5WZrnCbBMNHqp0XH)
	{
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = null;
		object obj = this.object_0;
		lock (obj)
		{
			int num = this.list_2.IndexOf(TGrXAM5jIHs0YeBYYK);
			if (num < 0 || num >= this.list_2.Count)
			{
				throw new ArgumentException("Invalid old value");
			}
			if (this.bool_0)
			{
				this.list_0.Add(mw5WZrnCbBMNHqp0XH);
				this.list_1.Add(TGrXAM5jIHs0YeBYYK);
			}
			this.list_2[num] = mw5WZrnCbBMNHqp0XH;
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, mw5WZrnCbBMNHqp0XH, TGrXAM5jIHs0YeBYYK, num);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	private void method_16(NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_0)
	{
		if (this.gdelegate0_0 != null && notifyCollectionChangedEventArgs_0 != null)
		{
			this.gdelegate0_0(this, notifyCollectionChangedEventArgs_0);
		}
	}

	public Mtu0HAjOQdBt0morPt method_17(int int_0)
	{
		return this.list_2[int_0];
	}

	public Mtu0HAjOQdBt0morPt method_18(int int_0, Mtu0HAjOQdBt0morPt ba1dNgxROpPbeBVxSD)
	{
		Mtu0HAjOQdBt0morPt mtu0HAjOQdBt0morPt = this.list_2[int_0];
		if (this.bool_0)
		{
			this.list_0.Add(ba1dNgxROpPbeBVxSD);
			this.list_1.Add(mtu0HAjOQdBt0morPt);
		}
		this.list_2[int_0] = ba1dNgxROpPbeBVxSD;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, ba1dNgxROpPbeBVxSD, mtu0HAjOQdBt0morPt, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_16(notifyCollectionChangedEventArgs_);
		return mtu0HAjOQdBt0morPt;
	}

	public void method_19(int int_0, Mtu0HAjOQdBt0morPt UhGC0dWEU4iaeMN1wC)
	{
		if (this.bool_0)
		{
			this.list_0.Add(UhGC0dWEU4iaeMN1wC);
		}
		this.list_2.Insert(int_0, UhGC0dWEU4iaeMN1wC);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, UhGC0dWEU4iaeMN1wC, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public Mtu0HAjOQdBt0morPt method_20(int int_0)
	{
		Mtu0HAjOQdBt0morPt mtu0HAjOQdBt0morPt = this.list_2[int_0];
		if (this.bool_0)
		{
			this.list_1.Add(mtu0HAjOQdBt0morPt);
		}
		this.list_2.RemoveAt(int_0);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, mtu0HAjOQdBt0morPt, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_16(notifyCollectionChangedEventArgs_);
		return mtu0HAjOQdBt0morPt;
	}

	public virtual void Clear()
	{
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = null;
		object obj = this.object_0;
		lock (obj)
		{
			if (this.bool_0)
			{
				this.list_1.AddRange(this.list_2);
			}
			this.list_2.Clear();
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_16(notifyCollectionChangedEventArgs_);
	}

	public bool Contains(Mtu0HAjOQdBt0morPt Fk8NwdVpyFSDNYX0t3)
	{
		object obj = this.object_0;
		bool result;
		lock (obj)
		{
			result = this.list_2.Contains(Fk8NwdVpyFSDNYX0t3);
		}
		return result;
	}

	public void CopyTo(Mtu0HAjOQdBt0morPt[] array, int arrayIndex)
	{
		object obj = this.object_0;
		lock (obj)
		{
			this.list_2.CopyTo(array, arrayIndex);
		}
	}

	public int Count
	{
		get
		{
			object obj = this.object_0;
			int count;
			lock (obj)
			{
				count = this.list_2.Count;
			}
			return count;
		}
	}

	public void method_21(object object_1)
	{
		this.method_14((Mtu0HAjOQdBt0morPt)((object)object_1));
	}

	public int method_22(object object_1)
	{
		return this.method_22((Mtu0HAjOQdBt0morPt)((object)object_1));
	}

	public object SyncRoot
	{
		get
		{
			return this.object_0;
		}
	}

	public bool method_23(IEnumerable<Mtu0HAjOQdBt0morPt> ienumerable_0)
	{
		if (this.Count != ienumerable_0.Count<Mtu0HAjOQdBt0morPt>())
		{
			return false;
		}
		object obj = this.object_0;
		lock (obj)
		{
			IEnumerator<Mtu0HAjOQdBt0morPt> enumerator = this.GetEnumerator();
			enumerator.Reset();
			foreach (Mtu0HAjOQdBt0morPt mtu0HAjOQdBt0morPt in ienumerable_0)
			{
				enumerator.MoveNext();
				Mtu0HAjOQdBt0morPt mtu0HAjOQdBt0morPt2 = enumerator.Current;
				if (mtu0HAjOQdBt0morPt2.Equals(mtu0HAjOQdBt0morPt))
				{
					return false;
				}
			}
			GClass2.smethod_0(enumerator);
		}
		return true;
	}

	private void method_24()
	{
		if (!this.method_23(this.ObsColl))
		{
			this.method_25();
		}
	}

	private void method_25()
	{
		object obj = this.object_0;
		lock (obj)
		{
			IEnumerator enumerator = this.list_2.GetEnumerator();
			IEnumerator enumerator2 = this.ObsColl.GetEnumerator();
			enumerator.Reset();
			enumerator2.Reset();
			bool flag2 = enumerator.MoveNext();
			bool flag3 = enumerator2.MoveNext();
			while (flag2 || flag3)
			{
				if (flag2)
				{
					flag2 = enumerator.MoveNext();
				}
				if (flag3)
				{
					flag3 = enumerator2.MoveNext();
				}
			}
			GClass2.smethod_0(enumerator);
			GClass2.smethod_0(enumerator2);
		}
	}

	[OnSerializing]
	private void method_26(StreamingContext streamingContext_0)
	{
		Monitor.Enter(this.object_0);
	}

	[OnSerialized]
	private void method_27(StreamingContext streamingContext_0)
	{
		Monitor.Exit(this.object_0);
	}

	[OnDeserializing]
	private void method_28(StreamingContext streamingContext_0)
	{
	}

	[OnDeserialized]
	private void method_29(StreamingContext streamingContext_0)
	{
	}

	public Mtu0HAjOQdBt0morPt this[int index]
	{
		get
		{
			return this.list_2[index];
		}
	}

	public void method_30(Mtu0HAjOQdBt0morPt piRIQSbdloryoZkZ9m)
	{
		this.Add(piRIQSbdloryoZkZ9m);
	}

	public bool method_31(out Mtu0HAjOQdBt0morPt gparam_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			int count = this.list_2.Count;
			if (count > 0)
			{
				gparam_0 = this.method_20(count - 1);
				return true;
			}
		}
		gparam_0 = default(Mtu0HAjOQdBt0morPt);
		return false;
	}

	public void method_32(Mtu0HAjOQdBt0morPt Si9DwJI3qGhyGYmk8b)
	{
		this.Add(Si9DwJI3qGhyGYmk8b);
	}

	public bool method_33(out Mtu0HAjOQdBt0morPt gparam_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			if (this.list_2.Count > 0)
			{
				gparam_0 = this.method_20(0);
				return true;
			}
		}
		gparam_0 = default(Mtu0HAjOQdBt0morPt);
		return false;
	}

	public bool IsReadOnly
	{
		get
		{
			return false;
		}
	}

	bool ICollection<Mtu0HAjOQdBt0morPt>.Remove(Mtu0HAjOQdBt0morPt rPhhN1C51kBBZiyG7s)
	{
		return this.method_14(rPhhN1C51kBBZiyG7s);
	}

	public void CopyTo(Array array, int index)
	{
		object obj = this.object_0;
		lock (obj)
		{
			foreach (Mtu0HAjOQdBt0morPt mtu0HAjOQdBt0morPt in this.list_2)
			{
				array.SetValue(mtu0HAjOQdBt0morPt, index++);
			}
		}
	}

	public bool IsSynchronized
	{
		get
		{
			return this.method_2().CheckAccess();
		}
	}

	private List<Mtu0HAjOQdBt0morPt> list_0;

	private List<Mtu0HAjOQdBt0morPt> list_1;

	private bool bool_0;

	private readonly object object_0;

	protected List<Mtu0HAjOQdBt0morPt> list_2;

	private readonly ObservableCollection<Mtu0HAjOQdBt0morPt> observableCollection_0;

	private readonly ConcurrentQueue<NotifyCollectionChangedEventArgs> concurrentQueue_0;

	[CompilerGenerated]
	private GDelegate0 gdelegate0_0;

	[CompilerGenerated]
	private Dispatcher dispatcher_0;
}

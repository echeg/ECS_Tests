using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System305 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component245),typeof(Component392),typeof(Component447),typeof(Component204) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component393Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component393Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component271Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component271Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component264Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component264Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component133Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component133Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

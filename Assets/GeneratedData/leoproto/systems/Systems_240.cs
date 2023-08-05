using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System240 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component170) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component5Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component5Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component224Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component224Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component488Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component488Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component396Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component396Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

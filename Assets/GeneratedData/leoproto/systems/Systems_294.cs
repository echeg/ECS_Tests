using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System294 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component413),typeof(Component249),typeof(Component318),typeof(Component114) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component180Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component180Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component4Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component4Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component60Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component60Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component308Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component308Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

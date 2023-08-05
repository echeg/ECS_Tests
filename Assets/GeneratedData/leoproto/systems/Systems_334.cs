using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System334 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component249) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component226Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component226Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component150Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component150Pool.Get(_it.Entity());
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
   if (_aspect.Component96Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component96Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

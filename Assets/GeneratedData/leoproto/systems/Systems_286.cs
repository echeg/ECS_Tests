using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System286 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component220),typeof(Component382),typeof(Component278) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component87Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component87Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component432Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component432Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component428Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component428Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component353Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component353Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

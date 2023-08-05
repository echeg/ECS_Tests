using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System313 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component3) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component26Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component26Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component43Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component43Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component363Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component363Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component139Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component139Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

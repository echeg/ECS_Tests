using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System238 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component338),typeof(Component118),typeof(Component489) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component30Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component30Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component420Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component420Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component56Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component56Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component493Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component493Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

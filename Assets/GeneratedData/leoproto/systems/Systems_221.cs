using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System221 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component381),typeof(Component344),typeof(Component422) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component396Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component396Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component55Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component55Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component30Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component30Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component485Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component485Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

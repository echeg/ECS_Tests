using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System295 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component286),typeof(Component40),typeof(Component130),typeof(Component404) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component40Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component40Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component12Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component12Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component138Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component138Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component189Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component189Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

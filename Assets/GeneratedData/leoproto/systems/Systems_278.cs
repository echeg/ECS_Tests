using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System278 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component226),typeof(Component356),typeof(Component161),typeof(Component54) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component44Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component44Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component185Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component185Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component73Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component73Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component323Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component323Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

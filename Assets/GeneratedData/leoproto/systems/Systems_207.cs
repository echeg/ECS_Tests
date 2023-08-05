using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System207 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component386),typeof(Component133),typeof(Component75),typeof(Component301) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component175Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component175Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component159Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component159Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component235Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component235Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component390Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component390Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

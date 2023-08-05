using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System291 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component227),typeof(Component419),typeof(Component33) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component475Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component475Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component256Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component256Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component364Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component364Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component418Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component418Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

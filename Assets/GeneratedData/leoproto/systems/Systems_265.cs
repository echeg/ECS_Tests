using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System265 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component84),typeof(Component329),typeof(Component421),typeof(Component484) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component283Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component283Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component326Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component326Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component202Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component202Pool.Get(_it.Entity());
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

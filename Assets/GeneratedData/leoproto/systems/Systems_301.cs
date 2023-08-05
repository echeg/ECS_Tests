using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System301 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component309),typeof(Component301),typeof(Component249),typeof(Component475) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component410Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component410Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component415Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component415Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component426Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component426Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component167Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component167Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

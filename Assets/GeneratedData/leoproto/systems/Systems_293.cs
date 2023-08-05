using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System293 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component106),typeof(Component425),typeof(Component373),typeof(Component270) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component70Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component70Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component335Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component335Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component213Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component213Pool.Get(_it.Entity());
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

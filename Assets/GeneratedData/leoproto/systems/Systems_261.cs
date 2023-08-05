using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System261 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component479),typeof(Component122),typeof(Component138),typeof(Component43) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component144Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component144Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component64Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component64Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component288Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component288Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component71Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component71Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

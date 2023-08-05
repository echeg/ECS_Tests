using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System314 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component385),typeof(Component311),typeof(Component405),typeof(Component272) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component352Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component352Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component379Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component379Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component453Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component453Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component245Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component245Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

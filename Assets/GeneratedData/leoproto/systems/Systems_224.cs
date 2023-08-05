using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System224 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component455),typeof(Component465),typeof(Component202) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component259Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component259Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component244Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component244Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component292Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component292Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component92Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component92Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

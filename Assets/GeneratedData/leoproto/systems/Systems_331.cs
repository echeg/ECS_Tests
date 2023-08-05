using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System331 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component424),typeof(Component405),typeof(Component144),typeof(Component473) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component322Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component322Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component437Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component437Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component423Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component423Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component402Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component402Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

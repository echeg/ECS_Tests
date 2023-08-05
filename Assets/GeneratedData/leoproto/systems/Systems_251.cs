using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System251 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component175),typeof(Component137),typeof(Component114),typeof(Component194) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component318Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component318Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component322Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component322Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component129Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component129Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component293Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component293Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System257 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component140),typeof(Component126) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component38Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component38Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component26Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component26Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component102Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component102Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component138Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component138Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

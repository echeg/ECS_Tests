using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System348 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component70),typeof(Component22),typeof(Component386) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
   if (_aspect.Component332Pool.Has(_it.Entity()))
   {
    _aspect.Component332Pool.Del(_it.Entity());
   }
   else
   {
    _aspect.Component332Pool.Add(_it.Entity());
   }
  }
 }
}

}

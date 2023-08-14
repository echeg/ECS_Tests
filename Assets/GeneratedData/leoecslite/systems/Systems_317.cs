using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System317 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component403> _p1;
EcsPool<Component409> _p2;
EcsPool<Component163> _p3;
EcsPool<Component17> _p4;
EcsPool<Component316> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component403>().Inc<Component409>().Inc<Component163>().Inc<Component17>().End();
   _p1 = _world.GetPool<Component403>();
   _p2 = _world.GetPool<Component409>();
   _p3 = _world.GetPool<Component163>();
   _p4 = _world.GetPool<Component17>();
   _pl0 = _world.GetPool<Component316>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   if (_p1.Has(entity))
   {
    _p1.Del(entity);
   }
   else
   {
    _p1.Add(entity);
   }
  }
 }
}

}

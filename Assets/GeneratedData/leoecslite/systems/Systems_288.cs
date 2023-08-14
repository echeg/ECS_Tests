using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System288 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component158> _p1;
EcsPool<Component97> _p2;
EcsPool<Component473> _p3;
EcsPool<Component290> _p4;
EcsPool<Component221> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component158>().Inc<Component97>().Inc<Component473>().Inc<Component290>().End();
   _p1 = _world.GetPool<Component158>();
   _p2 = _world.GetPool<Component97>();
   _p3 = _world.GetPool<Component473>();
   _p4 = _world.GetPool<Component290>();
   _pl0 = _world.GetPool<Component221>();
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

using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System204 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component467> _p1;
EcsPool<Component461> _p2;
EcsPool<Component386> _p3;
EcsPool<Component358> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component467>().Inc<Component461>().Inc<Component386>().End();
   _p1 = _world.GetPool<Component467>();
   _p2 = _world.GetPool<Component461>();
   _p3 = _world.GetPool<Component386>();
   _pl0 = _world.GetPool<Component358>();
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

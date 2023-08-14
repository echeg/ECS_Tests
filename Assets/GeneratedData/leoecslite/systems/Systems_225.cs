using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System225 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component238> _p1;
EcsPool<Component304> _p2;
EcsPool<Component184> _p3;
EcsPool<Component193> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component238>().Inc<Component304>().Inc<Component184>().End();
   _p1 = _world.GetPool<Component238>();
   _p2 = _world.GetPool<Component304>();
   _p3 = _world.GetPool<Component184>();
   _pl0 = _world.GetPool<Component193>();
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

using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System161 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component450> _p1;
EcsPool<Component469> _p2;
EcsPool<Component167> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component450>().Inc<Component469>().Inc<Component167>().End();
   _p1 = _world.GetPool<Component450>();
   _p2 = _world.GetPool<Component469>();
   _p3 = _world.GetPool<Component167>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}

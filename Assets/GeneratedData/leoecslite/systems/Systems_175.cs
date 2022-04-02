using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System175 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component390> _p1;
EcsPool<Component201> _p2;
EcsPool<Component477> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component390>().Inc<Component201>().Inc<Component477>().End();
   _p1 = _world.GetPool<Component390>();
   _p2 = _world.GetPool<Component201>();
   _p3 = _world.GetPool<Component477>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}

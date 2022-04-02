using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System156 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component135> _p1;
EcsPool<Component430> _p2;
EcsPool<Component411> _p3;
EcsPool<Component442> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component135>().Inc<Component430>().Inc<Component411>().Inc<Component442>().End();
   _p1 = _world.GetPool<Component135>();
   _p2 = _world.GetPool<Component430>();
   _p3 = _world.GetPool<Component411>();
   _p4 = _world.GetPool<Component442>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
